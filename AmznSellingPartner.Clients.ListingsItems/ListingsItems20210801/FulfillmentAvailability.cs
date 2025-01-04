namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The fulfillment availability details for the listings item.
	/// </summary>
	public class FulfillmentAvailability : BaseClass
	{
		/// <summary>
		/// The code of the fulfillment network that will be used.
		/// </summary>
		[JsonProperty("fulfillmentChannelCode")]
		[IsRequired]
		public string FulfillmentChannelCode { get; set; }

		/// <summary>
		/// The quantity of the item you are making available for sale.
		/// </summary>
		[JsonProperty("quantity")]
		[Minimum(0)]
		public int Quantity { get; set; }
	}
}
