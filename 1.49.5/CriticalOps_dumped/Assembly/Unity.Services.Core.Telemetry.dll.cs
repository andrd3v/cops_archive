// Namespace: 
internal class <Module>
{}

// Namespace: Unity.Services.Core.Telemetry.Internal
internal class Diagnostics
{
	// Fields
	private readonly System.Collections.Generic.IDictionary<System.String,System.String> <PackageTags>k__BackingField; // 0x10

	// Methods

	// RVA: 0x158DD68
	public void SendDiagnostic(string name, string message, System.Collections.Generic.IDictionary<System.String,System.String> tags) { }

	// RVA: 0x158DD6C
	public void .ctor() { }

}

// Namespace: Unity.Services.Core.Telemetry.Internal
internal class DiagnosticsFactory
{
	// Fields
	private readonly System.Collections.Generic.IReadOnlyDictionary<System.String,System.String> <CommonTags>k__BackingField; // 0x10

	// Methods

	// RVA: 0x158DDF8
	public IDiagnostics Create(string packageName) { }

	// RVA: 0x158DEBC
	public void .ctor() { }

}

// Namespace: Unity.Services.Core.Telemetry.Internal
internal class Metrics
{
	// Fields
	private readonly System.Collections.Generic.IDictionary<System.String,System.String> <PackageTags>k__BackingField; // 0x10

	// Methods

	// RVA: 0x158DF48
	private void Unity.Services.Core.Telemetry.Internal.IMetrics.SendGaugeMetric(string name, Double value, System.Collections.Generic.IDictionary<System.String,System.String> tags) { }

	// RVA: 0x158DF4C
	private void Unity.Services.Core.Telemetry.Internal.IMetrics.SendHistogramMetric(string name, Double time, System.Collections.Generic.IDictionary<System.String,System.String> tags) { }

	// RVA: 0x158DF50
	private void Unity.Services.Core.Telemetry.Internal.IMetrics.SendSumMetric(string name, Double value, System.Collections.Generic.IDictionary<System.String,System.String> tags) { }

	// RVA: 0x158DF54
	public void .ctor() { }

}

// Namespace: Unity.Services.Core.Telemetry.Internal
internal class MetricsFactory
{
	// Fields
	private readonly System.Collections.Generic.IReadOnlyDictionary<System.String,System.String> <CommonTags>k__BackingField; // 0x10

	// Methods

	// RVA: 0x158DFE0
	public IMetrics Create(string packageName) { }

	// RVA: 0x158E0A4
	public void .ctor() { }

}


