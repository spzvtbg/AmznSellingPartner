namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;

	/// <summary>
	/// Preferences that can be passed in context of an inbound order
	/// </summary>
	public class InboundPreferences : BaseClass
	{
		/// <summary>
		/// Pass a preferred region so that the inbound order can be shipped to an AWD warehouse located in that
		/// region. This doesn't guarantee the order to be assigned in the specified destination region as it depends
		/// on warehouse capacity availability. AWD currently supports following region IDs: [us-west, us-east]
		/// </summary>
		[JsonProperty("destinationRegion")]
		public string DestinationRegion { get; set; }
	}
}
