namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Details of an order.
	/// </summary>
	public class OrderDetails : BaseClass
	{
		/// <summary>
		/// The customer order number.
		/// </summary>
		[IsRequired]
		[JsonProperty("customerOrderNumber")]
		public string CustomerOrderNumber { get; set; }

		/// <summary>
		/// The date the order was placed. This  field is expected to be in ISO-8601 date/time format, for example:2018-07
		/// 16T23:00:00Z/ 2018-07-16T23:00:00-05:00 /2018-07-16T23:00:00-08:00. If no time zone is specified, UTC should b
		/// assumed.
		/// </summary>
		[IsRequired]
		[JsonProperty("orderDate")]
		public DateTime OrderDate { get; set; }

		/// <summary>
		/// Current status of the order.
		/// </summary>
		[JsonProperty("orderStatus")]
		public OrderStatus OrderStatus { get; set; }

		[IsRequired]
		[JsonProperty("shipmentDetails")]
		public ShipmentDetails ShipmentDetails { get; set; }

		[JsonProperty("taxTotal")]
		public TaxItemDetails TaxTotal { get; set; }

		/// <summary>
		/// PartyID of vendor code.
		/// </summary>
		[IsRequired]
		[JsonProperty("sellingParty")]
		public PartyIdentification SellingParty { get; set; }

		/// <summary>
		/// PartyID of vendor's warehouse.
		/// </summary>
		[IsRequired]
		[JsonProperty("shipFromParty")]
		public PartyIdentification ShipFromParty { get; set; }

		/// <summary>
		/// Name/Address and tax details of the ship to party.
		/// </summary>
		[IsRequired]
		[JsonProperty("shipToParty")]
		public Address ShipToParty { get; set; }

		/// <summary>
		/// Name/Address and tax details of the bill to party.
		/// </summary>
		[IsRequired]
		[JsonProperty("billToParty")]
		public PartyIdentification BillToParty { get; set; }

		/// <summary>
		/// A list of items in this purchase order.
		/// </summary>
		[IsRequired]
		[JsonProperty("items")]
		public List<OrderItem> Items { get; set; }
	}
}
