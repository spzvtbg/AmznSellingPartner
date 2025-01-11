namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The time range within which a Scheduled Delivery fulfillment order should be delivered. This
	/// is only available in the JP marketplace.
	/// </summary>
	public class DeliveryWindow : BaseClass
	{
		/// <summary>
		/// The date and time of the start of the Scheduled Delivery window. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
		/// 8601</a> format.
		/// </summary>
		[JsonProperty("startDate")]
		[IsRequired]
		public Timestamp StartDate { get; set; } 

		/// <summary>
		/// The date and time of the end of the Scheduled Delivery window. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
		/// 8601</a> format.
		/// </summary>
		[JsonProperty("endDate")]
		[IsRequired]
		public Timestamp EndDate { get; set; } 
	}
}
