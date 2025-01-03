namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A container that holds all of the necessary properties to configure the aggregation of notifications.
	/// </summary>
	public class AggregationSettings : BaseClass
	{
		/// <summary>
		/// The supported time period to use to perform marketplace-ASIN level aggregation.
		/// </summary>
		[IsRequired]
		[JsonProperty("aggregationTimePeriod")]
		public AggregationTimePeriod AggregationTimePeriod { get; set; }
	}
}
