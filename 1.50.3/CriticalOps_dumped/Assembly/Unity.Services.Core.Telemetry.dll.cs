// Namespace: 
internal class <Module>
{}

// Namespace: Unity.Services.Core.Telemetry.Internal
internal class Diagnostics
{
	// Fields
	private readonly System.Collections.Generic.IDictionary<System.String,System.String> <PackageTags>k__BackingField; // 0x10

	// Methods

	// RVA: 0x15B0F30
	public void SendDiagnostic(string name, string message, System.Collections.Generic.IDictionary<System.String,System.String> tags) { }

	// RVA: 0x15B0F34
	public void .ctor() { }

}

// Namespace: Unity.Services.Core.Telemetry.Internal
internal class DiagnosticsFactory
{
	// Fields
	private readonly System.Collections.Generic.IReadOnlyDictionary<System.String,System.String> <CommonTags>k__BackingField; // 0x10

	// Methods

	// RVA: 0x15B0FC0
	public IDiagnostics Create(string packageName) { }

	// RVA: 0x15B1084
	public void .ctor() { }

}

// Namespace: Unity.Services.Core.Telemetry.Internal
internal class Metrics
{
	// Fields
	private readonly System.Collections.Generic.IDictionary<System.String,System.String> <PackageTags>k__BackingField; // 0x10

	// Methods

	// RVA: 0x15B1110
	private void Unity.Services.Core.Telemetry.Internal.IMetrics.SendGaugeMetric(string name, Double value, System.Collections.Generic.IDictionary<System.String,System.String> tags) { }

	// RVA: 0x15B1114
	private void Unity.Services.Core.Telemetry.Internal.IMetrics.SendHistogramMetric(string name, Double time, System.Collections.Generic.IDictionary<System.String,System.String> tags) { }

	// RVA: 0x15B1118
	private void Unity.Services.Core.Telemetry.Internal.IMetrics.SendSumMetric(string name, Double value, System.Collections.Generic.IDictionary<System.String,System.String> tags) { }

	// RVA: 0x15B111C
	public void .ctor() { }

}

// Namespace: Unity.Services.Core.Telemetry.Internal
internal class MetricsFactory
{
	// Fields
	private readonly System.Collections.Generic.IReadOnlyDictionary<System.String,System.String> <CommonTags>k__BackingField; // 0x10

	// Methods

	// RVA: 0x15B11A8
	public IMetrics Create(string packageName) { }

	// RVA: 0x15B126C
	public void .ctor() { }

}


