namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The duration of time
	/// </summary>
	public class Duration : BaseClass
	{
		[JsonProperty("value")]
		public NonNegativeInteger Value { get; set; }

		[JsonProperty("timeUnit")]
		public TimeUnit TimeUnit { get; set; }
	}
}
