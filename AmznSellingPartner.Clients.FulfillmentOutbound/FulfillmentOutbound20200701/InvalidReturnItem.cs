namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// An item that is invalid for return.
	/// </summary>
	public class InvalidReturnItem : BaseClass
	{
		/// <summary>
		/// An identifier assigned by the seller to the return item.
		/// </summary>
		[JsonProperty("sellerReturnItemId")]
		[IsRequired]
		public string SellerReturnItemId { get; set; } 

		/// <summary>
		/// The identifier assigned to the item by the seller when the fulfillment order was created.
		/// </summary>
		[JsonProperty("sellerFulfillmentOrderItemId")]
		[IsRequired]
		public string SellerFulfillmentOrderItemId { get; set; } 

		[JsonProperty("invalidItemReason")]
		[IsRequired]
		public InvalidItemReason InvalidItemReason { get; set; } 
	}
}
