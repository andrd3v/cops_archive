// Namespace: 
internal class <Module>
{}

// Namespace: System.Configuration
public abstract class ConfigurationElement
{
	// Methods

	// RVA: 0xE521BC
	protected internal virtual ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0xE521F8
	protected internal virtual bool IsModified() { }

	// RVA: 0xE52234
	protected internal virtual void Reset(ConfigurationElement parentElement) { }

	// RVA: 0xE52270
	protected internal virtual void ResetModified() { }

}

// Namespace: System.Configuration
public abstract class ConfigurationSection
{
	// Methods

	// RVA: 0xE522AC
	protected internal virtual void DeserializeSection(XmlReader reader) { }

	// RVA: 0xE522E8
	protected internal override bool IsModified() { }

	// RVA: 0xE52324
	protected internal override void ResetModified() { }

	// RVA: 0xE52360
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

	// RVA: 0xE5239C
	public void .ctor(Type itemType) { }

}

// Namespace: System.Configuration
public class ConfigurationSectionGroup
{}

// Namespace: System.Configuration
public sealed class IgnoreSection
{
	// Methods

	// RVA: 0xE523A0
	public void .ctor() { }

	// RVA: 0xE523DC
	protected internal override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0xE52418
	protected internal override void DeserializeSection(XmlReader xmlReader) { }

	// RVA: 0xE52454
	protected internal override bool IsModified() { }

	// RVA: 0xE52490
	protected internal override void Reset(ConfigurationElement parentSection) { }

	// RVA: 0xE524CC
	protected internal override void ResetModified() { }

	// RVA: 0xE52508
	protected internal override string SerializeSection(ConfigurationElement parentSection, string name, ConfigurationSaveMode saveMode) { }

}

// Namespace: Unity
internal sealed class ThrowStub
{
	// Methods

	// RVA: 0xE52544
	public static void ThrowNotSupportedException() { }

}


