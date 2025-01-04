namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
	using Newtonsoft.Json;

	/// <summary>
	/// Gift details for the item.
	/// </summary>
	public class GiftDetails : BaseClass
	{
		/// <summary>
		/// Gift message to be printed in shipment.
		/// </summary>
		[JsonProperty("giftMessage")]
		public string GiftMessage { get; set; } 

		/// <summary>
		/// Gift wrap identifier for the gift wrapping, if any.
		/// </summary>
		[JsonProperty("giftWrapId")]
		public string GiftWrapId { get; set; } 
	}
}
