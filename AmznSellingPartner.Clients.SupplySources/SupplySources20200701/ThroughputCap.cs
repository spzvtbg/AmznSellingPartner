namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The throughput capacity
	/// </summary>
	public class ThroughputCap : BaseClass
	{
		[JsonProperty("value")]
		public NonNegativeInteger Value { get; set; }

		[JsonProperty("timeUnit")]
		public TimeUnit TimeUnit { get; set; }
	}
}
