namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using Newtonsoft.Json;

	/// <summary>
	/// A filter used to select the aggregation time period at which to send notifications (for example: limit to one
	/// otification every five minutes for high frequency notifications)
	/// </summary>
	public class AggregationFilter : BaseClass
	{
		[JsonProperty("aggregationSettings")]
		public AggregationSettings AggregationSettings { get; set; }
	}
}
