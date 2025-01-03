namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// Current status of a purchase order
	/// </summary>
	public class OrderStatus : BaseClass
	{
		/// <summary>
		/// The buyer's purchase order number for this order
		/// Formatting Notes: 8-character alpha-numeric code
		/// </summary>
		[IsRequired]
		[JsonProperty("purchaseOrderNumber")]
		public string PurchaseOrderNumber { get; set; }

		/// <summary>
		/// The status of the buyer's purchase order for this order
		/// </summary>
		[IsRequired]
		[JsonProperty("purchaseOrderStatus")]
		public PurchaseOrderStatus PurchaseOrderStatus { get; set; }

		/// <summary>
		/// The date the purchase order was placed
		/// Must be in ISO-8601 date/time format
		/// </summary>
		[IsRequired]
		[JsonProperty("purchaseOrderDate")]
		public DateTime PurchaseOrderDate { get; set; }

		/// <summary>
		/// The date when the purchase order was last updated
		/// Must be in ISO-8601 date/time format
		/// </summary>
		[JsonProperty("lastUpdatedDate")]
		public DateTime LastUpdatedDate { get; set; }

		/// <summary>
		/// Name/Address and tax details of the selling party
		/// </summary>
		[IsRequired]
		[JsonProperty("sellingParty")]
		public PartyIdentification SellingParty { get; set; }

		/// <summary>
		/// Name/Address and tax details of the ship to party
		/// Find a list of fulfillment center addresses for a region on the [Resources page of Amazon Vendor Central](htt
		/// s://vendorcentral
		/// amazon
		/// com/hz/vendor/members/support/help/node/GPZ88XH8HQM97ZV6)
		/// </summary>
		[IsRequired]
		[JsonProperty("shipToParty")]
		public PartyIdentification ShipToParty { get; set; }

		/// <summary>
		/// Detailed order status
		/// </summary>
		[IsRequired]
		[JsonProperty("itemStatus")]
		public ItemStatus ItemStatus { get; set; }
	}
}
