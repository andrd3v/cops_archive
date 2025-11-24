// Namespace: 
internal class <Module>
{}

// Namespace: Unity.Services.Core.Telemetry.Internal
internal class Diagnostics
{
	// Fields
	private readonly System.Collections.Generic.IDictionary<System.String,System.String> <PackageTags>k__BackingField; // 0x10

	// Methods

	// RVA: 0x15F4414
	public void SendDiagnostic(string name, string message, System.Collections.Generic.IDictionary<System.String,System.String> tags) { }

	// RVA: 0x15F4418
	public void .ctor() { }

}

// Namespace: Unity.Services.Core.Telemetry.Internal
internal class DiagnosticsFactory
{
	// Fields
	private readonly System.Collections.Generic.IReadOnlyDictionary<System.String,System.String> <CommonTags>k__BackingField; // 0x10

	// Methods

	// RVA: 0x15F44A4
	public IDiagnostics Create(string packageName) { }

	// RVA: 0x15F4568
	public void .ctor() { }

}

// Namespace: Unity.Services.Core.Telemetry.Internal
internal class Metrics
{
	// Fields
	private readonly System.Collections.Generic.IDictionary<System.String,System.String> <PackageTags>k__BackingField; // 0x10

	// Methods

	// RVA: 0x15F45F4
	private void Unity.Services.Core.Telemetry.Internal.IMetrics.SendGaugeMetric(string name, Double value, System.Collections.Generic.IDictionary<System.String,System.String> tags) { }

	// RVA: 0x15F45F8
	private void Unity.Services.Core.Telemetry.Internal.IMetrics.SendHistogramMetric(string name, Double time, System.Collections.Generic.IDictionary<System.String,System.String> tags) { }

	// RVA: 0x15F45FC
	private void Unity.Services.Core.Telemetry.Internal.IMetrics.SendSumMetric(string name, Double value, System.Collections.Generic.IDictionary<System.String,System.String> tags) { }

	// RVA: 0x15F4600
	public void .ctor() { }

}

// Namespace: Unity.Services.Core.Telemetry.Internal
internal class MetricsFactory
{
	// Fields
	private readonly System.Collections.Generic.IReadOnlyDictionary<System.String,System.String> <CommonTags>k__BackingField; // 0x10

	// Methods

	// RVA: 0x15F468C
	public IMetrics Create(string packageName) { }

	// RVA: 0x15F4750
	public void .ctor() { }

}


