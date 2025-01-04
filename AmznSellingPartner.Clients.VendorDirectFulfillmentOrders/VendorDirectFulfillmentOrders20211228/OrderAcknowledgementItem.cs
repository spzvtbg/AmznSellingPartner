namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Details of an individual order being acknowledged.
	/// </summary>
	public class OrderAcknowledgementItem : BaseClass
	{
		/// <summary>
		/// The purchase order number for this order. Formatting Notes: alpha-numeric code.
		/// </summary>
		[JsonProperty("purchaseOrderNumber")]
		[IsRequired]
		public string PurchaseOrderNumber { get; set; } 

		/// <summary>
		/// The vendor's order number for this order.
		/// </summary>
		[JsonProperty("vendorOrderNumber")]
		[IsRequired]
		public string VendorOrderNumber { get; set; } 

		/// <summary>
		/// The date and time when the order is acknowledged, in ISO-8601 date/time format. For example: 2018-07-16T23:00:00Z
		/// / 2018-07-16T23:00:00-05:00 / 2018-07-16T23:00:00-08:00.
		/// </summary>
		[JsonProperty("acknowledgementDate")]
		[IsRequired]
		public DateTime AcknowledgementDate { get; set; } 

		/// <summary>
		/// Status of acknowledgement.
		/// </summary>
		[JsonProperty("acknowledgementStatus")]
		[IsRequired]
		public AcknowledgementStatus AcknowledgementStatus { get; set; } 

		/// <summary>
		/// PartyID as vendor code.
		/// </summary>
		[JsonProperty("sellingParty")]
		[IsRequired]
		public PartyIdentification SellingParty { get; set; } 

		/// <summary>
		/// PartyID as the vendor's warehouseId.
		/// </summary>
		[JsonProperty("shipFromParty")]
		[IsRequired]
		public PartyIdentification ShipFromParty { get; set; } 

		/// <summary>
		/// Item details including acknowledged quantity.
		/// </summary>
		[JsonProperty("itemAcknowledgements")]
		[IsRequired]
		public List<OrderItemAcknowledgement> ItemAcknowledgements { get; set; } 
	}
}
