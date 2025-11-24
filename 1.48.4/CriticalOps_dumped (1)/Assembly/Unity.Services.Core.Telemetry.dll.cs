// Namespace: 
internal class <Module> 
{}

// Namespace: Unity.Services.Core.Telemetry.Internal
internal class Diagnostics 
{
	// Fields
	private readonly System.Collections.Generic.IDictionary<System.String,System.String> <PackageTags>k__BackingField; // 0x10

	// Methods

	// RVA: 0x149B6BC
	void SendDiagnostic(string name, string message, System.Collections.Generic.IDictionary<System.String,System.String> tags) { }

	// RVA: 0x149B6C0
	void .ctor() { }

}

// Namespace: Unity.Services.Core.Telemetry.Internal
internal class DiagnosticsFactory 
{
	// Fields
	private readonly System.Collections.Generic.IReadOnlyDictionary<System.String,System.String> <CommonTags>k__BackingField; // 0x10

	// Methods

	// RVA: 0x149B74C
	IDiagnostics Create(string packageName) { }

	// RVA: 0x149B810
	void .ctor() { }

}

// Namespace: Unity.Services.Core.Telemetry.Internal
internal class Metrics 
{
	// Fields
	private readonly System.Collections.Generic.IDictionary<System.String,System.String> <PackageTags>k__BackingField; // 0x10

	// Methods

	// RVA: 0x149B89C
	void Unity.Services.Core.Telemetry.Internal.IMetrics.SendGaugeMetric(string name, Double value, System.Collections.Generic.IDictionary<System.String,System.String> tags) { }

	// RVA: 0x149B8A0
	void Unity.Services.Core.Telemetry.Internal.IMetrics.SendHistogramMetric(string name, Double time, System.Collections.Generic.IDictionary<System.String,System.String> tags) { }

	// RVA: 0x149B8A4
	void Unity.Services.Core.Telemetry.Internal.IMetrics.SendSumMetric(string name, Double value, System.Collections.Generic.IDictionary<System.String,System.String> tags) { }

	// RVA: 0x149B8A8
	void .ctor() { }

}

// Namespace: Unity.Services.Core.Telemetry.Internal
internal class MetricsFactory 
{
	// Fields
	private readonly System.Collections.Generic.IReadOnlyDictionary<System.String,System.String> <CommonTags>k__BackingField; // 0x10

	// Methods

	// RVA: 0x149B934
	IMetrics Create(string packageName) { }

	// RVA: 0x149B9F8
	void .ctor() { }

}


