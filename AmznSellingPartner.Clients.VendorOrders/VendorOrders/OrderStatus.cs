namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// Current status of a purchase order.
	/// </summary>
	public class OrderStatus : BaseClass
	{
		/// <summary>
		/// The buyer's purchase order number for this order. Formatting Notes: 8-character alpha-numeric code.
		/// </summary>
		[JsonProperty("purchaseOrderNumber")]
		[IsRequired]
		public string PurchaseOrderNumber { get; set; } 

		/// <summary>
		/// The status of the buyer's purchase order for this order.
		/// </summary>
		[JsonProperty("purchaseOrderStatus")]
		[IsRequired]
		public PurchaseOrderStatus PurchaseOrderStatus { get; set; } 

		/// <summary>
		/// The date the purchase order was placed. Must be in ISO-8601 date/time format.
		/// </summary>
		[JsonProperty("purchaseOrderDate")]
		[IsRequired]
		public DateTime PurchaseOrderDate { get; set; } 

		/// <summary>
		/// The date when the purchase order was last updated. Must be in ISO-8601 date/time format.
		/// </summary>
		[JsonProperty("lastUpdatedDate")]
		public DateTime LastUpdatedDate { get; set; } 

		/// <summary>
		/// Name/Address and tax details of the selling party.
		/// </summary>
		[JsonProperty("sellingParty")]
		[IsRequired]
		public PartyIdentification SellingParty { get; set; } 

		/// <summary>
		/// Name/Address and tax details of the ship to party. Find a list of fulfillment center addresses for a
		/// region on the [Resources page of Amazon Vendor Central](https://vendorcentral.amazon.com/hz/vendor/m
		/// embers/support/help/node/GPZ88XH8HQM97ZV6).
		/// </summary>
		[JsonProperty("shipToParty")]
		[IsRequired]
		public PartyIdentification ShipToParty { get; set; } 

		/// <summary>
		/// Detailed order status.
		/// </summary>
		[JsonProperty("itemStatus")]
		[IsRequired]
		public ItemStatus ItemStatus { get; set; } 
	}
}
