// Namespace: 
internal class <Module>
{}

// Namespace: Unity.Services.Core.Telemetry.Internal
internal class Diagnostics
{
	// Fields
	private readonly System.Collections.Generic.IDictionary<System.String,System.String> <PackageTags>k__BackingField; // 0x10

	// Methods

	// RVA: 0x157EA38
	public void SendDiagnostic(string name, string message, System.Collections.Generic.IDictionary<System.String,System.String> tags) { }

	// RVA: 0x157EA3C
	public void .ctor() { }

}

// Namespace: Unity.Services.Core.Telemetry.Internal
internal class DiagnosticsFactory
{
	// Fields
	private readonly System.Collections.Generic.IReadOnlyDictionary<System.String,System.String> <CommonTags>k__BackingField; // 0x10

	// Methods

	// RVA: 0x157EAC8
	public IDiagnostics Create(string packageName) { }

	// RVA: 0x157EB8C
	public void .ctor() { }

}

// Namespace: Unity.Services.Core.Telemetry.Internal
internal class Metrics
{
	// Fields
	private readonly System.Collections.Generic.IDictionary<System.String,System.String> <PackageTags>k__BackingField; // 0x10

	// Methods

	// RVA: 0x157EC18
	private void Unity.Services.Core.Telemetry.Internal.IMetrics.SendGaugeMetric(string name, Double value, System.Collections.Generic.IDictionary<System.String,System.String> tags) { }

	// RVA: 0x157EC1C
	private void Unity.Services.Core.Telemetry.Internal.IMetrics.SendHistogramMetric(string name, Double time, System.Collections.Generic.IDictionary<System.String,System.String> tags) { }

	// RVA: 0x157EC20
	private void Unity.Services.Core.Telemetry.Internal.IMetrics.SendSumMetric(string name, Double value, System.Collections.Generic.IDictionary<System.String,System.String> tags) { }

	// RVA: 0x157EC24
	public void .ctor() { }

}

// Namespace: Unity.Services.Core.Telemetry.Internal
internal class MetricsFactory
{
	// Fields
	private readonly System.Collections.Generic.IReadOnlyDictionary<System.String,System.String> <CommonTags>k__BackingField; // 0x10

	// Methods

	// RVA: 0x157ECB0
	public IMetrics Create(string packageName) { }

	// RVA: 0x157ED74
	public void .ctor() { }

}


