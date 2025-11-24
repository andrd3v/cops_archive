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

	// RVA: 0x16AAB80
	public void .ctor(string preferredExtension, string[] otherExtensions) { }

}

// Namespace: UnityEngine
internal class ThreadAndSerializationSafeAttribute
{
	// Methods

	// RVA: 0x16AABD0
	public void .ctor() { }

}

// Namespace: UnityEngine
internal class WritableAttribute
{
	// Methods

	// RVA: 0x16AABD8
	public void .ctor() { }

}

// Namespace: UnityEngine
internal class UnityEngineModuleAssembly
{
	// Methods

	// RVA: 0x16AABE0
	public void .ctor() { }

}

// Namespace: UnityEngine
internal sealed class NativeClassAttribute
{
	// Fields
	private string <QualifiedNativeName>k__BackingField; // 0x10
	private string <Declaration>k__BackingField; // 0x18

	// Methods

	// RVA: 0x16AABE8
	private void set_QualifiedNativeName(string value) { }

	// RVA: 0x16AABF0
	private void set_Declaration(string value) { }

	// RVA: 0x16AABF8
	public void .ctor(string qualifiedCppName) { }

	// RVA: 0x16AAC80
	public void .ctor(string qualifiedCppName, string declaration) { }

}

// Namespace: UnityEngine
internal sealed class UnityString
{
	// Methods

	// RVA: 0x16AACD0
	public static string Format(string fmt, object[] args) { }

}

// Namespace: UnityEngine.Bindings
internal class VisibleToOtherModulesAttribute
{
	// Methods

	// RVA: 0x16AAD74
	public void .ctor() { }

	// RVA: 0x16AAD7C
	public void .ctor(string[] modules) { }

}

// Namespace: UnityEngine.Bindings
internal class NativeConditionalAttribute
{
	// Fields
	private string <Condition>k__BackingField; // 0x10
	private bool <Enabled>k__BackingField; // 0x18

	// Methods

	// RVA: 0x16AAD84
	public void set_Condition(string value) { }

	// RVA: 0x16AAD8C
	public void set_Enabled(bool value) { }

	// RVA: 0x16AAD94
	public void .ctor(string condition) { }

}

// Namespace: UnityEngine.Bindings
internal class NativeHeaderAttribute
{
	// Fields
	private string <Header>k__BackingField; // 0x10

	// Methods

	// RVA: 0x16AADD4
	public void set_Header(string value) { }

	// RVA: 0x16AADDC
	public void .ctor(string header) { }

}

// Namespace: UnityEngine.Bindings
internal class NativeNameAttribute
{
	// Fields
	private string <Name>k__BackingField; // 0x10

	// Methods

	// RVA: 0x16AAF00
	public void set_Name(string value) { }

	// RVA: 0x16AAF08
	public void .ctor(string name) { }

}

// Namespace: UnityEngine.Bindings
internal sealed class NativeWritableSelfAttribute
{
	// Fields
	private bool <WritableSelf>k__BackingField; // 0x10

	// Methods

	// RVA: 0x16AB02C
	public void set_WritableSelf(bool value) { }

	// RVA: 0x16AB034
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

	// RVA: 0x16AB060
	public void set_Name(string value) { }

	// RVA: 0x16AB068
	public void set_IsThreadSafe(bool value) { }

	// RVA: 0x16AB070
	public void set_IsFreeFunction(bool value) { }

	// RVA: 0x16AB078
	public void set_ThrowsException(bool value) { }

	// RVA: 0x16AB080
	public void set_HasExplicitThis(bool value) { }

	// RVA: 0x16AB088
	public void .ctor() { }

	// RVA: 0x16AB090
	public void .ctor(string name) { }

	// RVA: 0x16AB1B4
	public void .ctor(string name, bool isFreeFunction) { }

	// RVA: 0x16AB1DC
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

	// RVA: 0x16AB214
	public void set_TargetType(TargetType value) { }

	// RVA: 0x16AB21C
	public void .ctor() { }

	// RVA: 0x16AB224
	public void .ctor(string name) { }

	// RVA: 0x16AB228
	public void .ctor(string name, bool isFree, TargetType targetType) { }

	// RVA: 0x16AB260
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

	// RVA: 0x16AB2A0
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

	// RVA: 0x16AB2A8
	public void set_Header(string value) { }

	// RVA: 0x16AB2B0
	public void set_IntermediateScriptingStructName(string value) { }

	// RVA: 0x16AB2B8
	public void set_CodegenOptions(CodegenOptions value) { }

	// RVA: 0x16AB2C0
	public void .ctor() { }

	// RVA: 0x16AB2E8
	public void .ctor(CodegenOptions codegenOptions) { }

	// RVA: 0x16AB314
	public void .ctor(string header) { }

	// RVA: 0x16AB43C
	public void .ctor(CodegenOptions codegenOptions, string intermediateStructName) { }

}

// Namespace: UnityEngine.Bindings
internal class NotNullAttribute
{
	// Fields
	private string <Exception>k__BackingField; // 0x10

	// Methods

	// RVA: 0x16AB480
	public void set_Exception(string value) { }

	// RVA: 0x16AB488
	public void .ctor(string exception) { }

}

// Namespace: UnityEngine.Bindings
internal class UnmarshalledAttribute
{
	// Methods

	// RVA: 0x16AB4BC
	public void .ctor() { }

}

// Namespace: UnityEngine.Bindings
internal class FreeFunctionAttribute
{
	// Methods

	// RVA: 0x16AB4C4
	public void .ctor() { }

	// RVA: 0x16AB4F0
	public void .ctor(string name) { }

	// RVA: 0x16AB518
	public void .ctor(string name, bool isThreadSafe) { }

}

// Namespace: UnityEngine.Bindings
internal class ThreadSafeAttribute
{
	// Methods

	// RVA: 0x16AB548
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

	// RVA: 0x16AB574
	public void set_Name(string value) { }

	// RVA: 0x16AB57C
	public void set_Type(StaticAccessorType value) { }

	// RVA: 0x16AB584
	internal void .ctor(string name) { }

	// RVA: 0x16AB5B8
	public void .ctor(string name, StaticAccessorType type) { }

}

// Namespace: UnityEngine.Bindings
internal class NativeThrowsAttribute
{
	// Fields
	private bool <ThrowsException>k__BackingField; // 0x10

	// Methods

	// RVA: 0x16AB600
	public void set_ThrowsException(bool value) { }

	// RVA: 0x16AB608
	public void .ctor() { }

}

// Namespace: UnityEngine.Bindings
internal class IgnoreAttribute
{
	// Fields
	private bool <DoesNotContributeToSize>k__BackingField; // 0x10

	// Methods

	// RVA: 0x16AB634
	public void set_DoesNotContributeToSize(bool value) { }

	// RVA: 0x16AB63C
	public void .ctor() { }

}

// Namespace: UnityEngine.Bindings
internal class PreventReadOnlyInstanceModificationAttribute
{
	// Methods

	// RVA: 0x16AB644
	public void .ctor() { }

}

// Namespace: UnityEngine.Scripting
internal class UsedByNativeCodeAttribute
{
	// Methods

	// RVA: 0x16AB64C
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

	// RVA: 0x16AB654
	public void .ctor() { }

	// RVA: 0x16AB65C
	public void .ctor(string name) { }

	// RVA: 0x16AB690
	public void set_Name(string value) { }

	// RVA: 0x16AB698
	public void set_Optional(bool value) { }

	// RVA: 0x16AB6A0
	public void set_GenerateProxy(bool value) { }

}


