namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// Dates for the scheduled delivery shipments
	/// </summary>
	public class ScheduledDeliveryShipment : BaseClass
	{
		/// <summary>
		/// Scheduled delivery service type
		/// </summary>
		[JsonProperty("scheduledDeliveryServiceType")]
		public string ScheduledDeliveryServiceType { get; set; }

		/// <summary>
		/// Earliest nominated delivery date for the scheduled delivery
		/// </summary>
		[JsonProperty("earliestNominatedDeliveryDate")]
		public DateTime EarliestNominatedDeliveryDate { get; set; }

		/// <summary>
		/// Latest nominated delivery date for the scheduled delivery
		/// </summary>
		[JsonProperty("latestNominatedDeliveryDate")]
		public DateTime LatestNominatedDeliveryDate { get; set; }
	}
}
