// Namespace: 
internal class <Module> 
{}

// Namespace: System.Configuration
public abstract class ConfigurationElement 
{
	// Methods

	// RVA: 0xE0243C
	ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0xE02478
	bool IsModified() { }

	// RVA: 0xE024B4
	void Reset(ConfigurationElement parentElement) { }

	// RVA: 0xE024F0
	void ResetModified() { }

}

// Namespace: System.Configuration
public abstract class ConfigurationSection 
{
	// Methods

	// RVA: 0xE0252C
	void DeserializeSection(XmlReader reader) { }

	// RVA: 0xE02568
	bool IsModified() { }

	// RVA: 0xE025A4
	void ResetModified() { }

	// RVA: 0xE025E0
	string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode) { }

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

	// RVA: 0xE0261C
	void .ctor(Type itemType) { }

}

// Namespace: System.Configuration
public class ConfigurationSectionGroup 
{}

// Namespace: System.Configuration
public sealed class IgnoreSection 
{
	// Methods

	// RVA: 0xE02620
	void .ctor() { }

	// RVA: 0xE0265C
	ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0xE02698
	void DeserializeSection(XmlReader xmlReader) { }

	// RVA: 0xE026D4
	bool IsModified() { }

	// RVA: 0xE02710
	void Reset(ConfigurationElement parentSection) { }

	// RVA: 0xE0274C
	void ResetModified() { }

	// RVA: 0xE02788
	string SerializeSection(ConfigurationElement parentSection, string name, ConfigurationSaveMode saveMode) { }

}

// Namespace: Unity
internal sealed class ThrowStub 
{
	// Methods

	// RVA: 0xE027C4
	void ThrowNotSupportedException() { }

}


