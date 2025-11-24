// Namespace: 
internal class <Module>
{}

// Namespace: System.Configuration
public abstract class ConfigurationElement
{
	// Methods

	// RVA: 0xE38C98
	protected internal virtual ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0xE38CD4
	protected internal virtual bool IsModified() { }

	// RVA: 0xE38D10
	protected internal virtual void Reset(ConfigurationElement parentElement) { }

	// RVA: 0xE38D4C
	protected internal virtual void ResetModified() { }

}

// Namespace: System.Configuration
public abstract class ConfigurationSection
{
	// Methods

	// RVA: 0xE38D88
	protected internal virtual void DeserializeSection(XmlReader reader) { }

	// RVA: 0xE38DC4
	protected internal override bool IsModified() { }

	// RVA: 0xE38E00
	protected internal override void ResetModified() { }

	// RVA: 0xE38E3C
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

	// RVA: 0xE38E78
	public void .ctor(Type itemType) { }

}

// Namespace: System.Configuration
public class ConfigurationSectionGroup
{}

// Namespace: System.Configuration
public sealed class IgnoreSection
{
	// Methods

	// RVA: 0xE38E7C
	public void .ctor() { }

	// RVA: 0xE38EB8
	protected internal override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0xE38EF4
	protected internal override void DeserializeSection(XmlReader xmlReader) { }

	// RVA: 0xE38F30
	protected internal override bool IsModified() { }

	// RVA: 0xE38F6C
	protected internal override void Reset(ConfigurationElement parentSection) { }

	// RVA: 0xE38FA8
	protected internal override void ResetModified() { }

	// RVA: 0xE38FE4
	protected internal override string SerializeSection(ConfigurationElement parentSection, string name, ConfigurationSaveMode saveMode) { }

}

// Namespace: Unity
internal sealed class ThrowStub
{
	// Methods

	// RVA: 0xE39020
	public static void ThrowNotSupportedException() { }

}


