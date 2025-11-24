// Namespace: 
internal class <Module>
{}

// Namespace: System.Configuration
public abstract class ConfigurationElement
{
	// Methods

	// RVA: 0xE29968
	protected internal virtual ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0xE299A4
	protected internal virtual bool IsModified() { }

	// RVA: 0xE299E0
	protected internal virtual void Reset(ConfigurationElement parentElement) { }

	// RVA: 0xE29A1C
	protected internal virtual void ResetModified() { }

}

// Namespace: System.Configuration
public abstract class ConfigurationSection
{
	// Methods

	// RVA: 0xE29A58
	protected internal virtual void DeserializeSection(XmlReader reader) { }

	// RVA: 0xE29A94
	protected internal override bool IsModified() { }

	// RVA: 0xE29AD0
	protected internal override void ResetModified() { }

	// RVA: 0xE29B0C
	protected internal virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode) { }

}

// Namespace: System.Configuration
public enum ConfigurationSaveMode
{
	// Fields
	public int value__; // 0x10
	public const ConfigurationSaveMode Full = 2;
	public const ConfigurationSaveMode Minimal = 1;
	public const ConfigurationSaveMode Modified = 0;
}

// Namespace: System.Configuration
public class ConfigurationPropertyCollection
{}

// Namespace: System.Configuration
public abstract class ConfigurationElementCollection
{}

// Namespace: System.Configuration
public sealed class ConfigurationCollectionAttribute
{
	// Methods

	// RVA: 0xE29B48
	public void .ctor(Type itemType) { }

}

// Namespace: System.Configuration
public class ConfigurationSectionGroup
{}

// Namespace: System.Configuration
public sealed class IgnoreSection
{
	// Methods

	// RVA: 0xE29B4C
	public void .ctor() { }

	// RVA: 0xE29B88
	protected internal override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0xE29BC4
	protected internal override void DeserializeSection(XmlReader xmlReader) { }

	// RVA: 0xE29C00
	protected internal override bool IsModified() { }

	// RVA: 0xE29C3C
	protected internal override void Reset(ConfigurationElement parentSection) { }

	// RVA: 0xE29C78
	protected internal override void ResetModified() { }

	// RVA: 0xE29CB4
	protected internal override string SerializeSection(ConfigurationElement parentSection, string name, ConfigurationSaveMode saveMode) { }

}

// Namespace: Unity
internal sealed class ThrowStub
{
	// Methods

	// RVA: 0xE29CF0
	public static void ThrowNotSupportedException() { }

}


