namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The operational configuration of `supplySources`
	/// </summary>
	public class OperationalConfiguration : BaseClass
	{
		[JsonProperty("contactDetails")]
		public ContactDetails ContactDetails { get; set; }

		[JsonProperty("throughputConfig")]
		public ThroughputConfig ThroughputConfig { get; set; }

		[JsonProperty("operatingHoursByDay")]
		public OperatingHoursByDay OperatingHoursByDay { get; set; }

		[JsonProperty("handlingTime")]
		public Duration HandlingTime { get; set; }
	}
}
