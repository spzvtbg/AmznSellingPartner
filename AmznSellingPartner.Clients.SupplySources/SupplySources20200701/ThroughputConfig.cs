namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The throughput configuration.
	/// </summary>
	public class ThroughputConfig : BaseClass
	{
		[JsonProperty("throughputCap")]
		public ThroughputCap ThroughputCap { get; set; }

		[IsRequired]
		[JsonProperty("throughputUnit")]
		public ThroughputUnit ThroughputUnit { get; set; }
	}
}
