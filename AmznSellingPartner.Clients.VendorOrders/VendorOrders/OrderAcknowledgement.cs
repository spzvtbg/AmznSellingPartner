namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Represents an acknowledgement for an order, including the purchase order number, selling party details,
	/// acknowledgement date, and a list of acknowledged items.
	/// </summary>
	public class OrderAcknowledgement : BaseClass
	{
		/// <summary>
		/// The purchase order number. Formatting Notes: 8-character alpha-numeric code.
		/// </summary>
		[JsonProperty("purchaseOrderNumber")]
		[IsRequired]
		public string PurchaseOrderNumber { get; set; } 

		/// <summary>
		/// Name, address and tax details of the party receiving a shipment of products.
		/// </summary>
		[JsonProperty("sellingParty")]
		[IsRequired]
		public PartyIdentification SellingParty { get; set; } 

		/// <summary>
		/// The date and time when the purchase order is acknowledged, in ISO-8601 date/time format.
		/// </summary>
		[JsonProperty("acknowledgementDate")]
		[IsRequired]
		public DateTime AcknowledgementDate { get; set; } 

		/// <summary>
		/// A list of the items being acknowledged with associated details.
		/// </summary>
		[JsonProperty("items")]
		[IsRequired]
		public List<OrderAcknowledgementItem> Items { get; set; } 
	}
}
