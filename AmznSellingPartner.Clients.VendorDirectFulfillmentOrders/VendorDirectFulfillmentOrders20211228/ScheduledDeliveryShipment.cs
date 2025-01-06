namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	/// <summary>
	/// Dates for the scheduled delivery shipments.
	/// </summary>
	public class ScheduledDeliveryShipment : BaseClass
	{
		/// <summary>
		/// Scheduled delivery service type.
		/// </summary>
		[JsonProperty("scheduledDeliveryServiceType")]
		public string ScheduledDeliveryServiceType { get; set; } 

		/// <summary>
		/// Earliest nominated delivery date for the scheduled delivery.
		/// </summary>
		[JsonProperty("earliestNominatedDeliveryDate")]
		public DateTimeValue EarliestNominatedDeliveryDate { get; set; } 

		/// <summary>
		/// Latest nominated delivery date for the scheduled delivery.
		/// </summary>
		[JsonProperty("latestNominatedDeliveryDate")]
		public DateTimeValue LatestNominatedDeliveryDate { get; set; } 
	}
}
