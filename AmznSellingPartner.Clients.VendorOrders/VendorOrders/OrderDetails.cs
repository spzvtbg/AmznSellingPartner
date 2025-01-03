namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Details of an order
	/// </summary>
	public class OrderDetails : BaseClass
	{
		/// <summary>
		/// The date the purchase order was placed
		/// Must be in ISO-8601 date/time format
		/// </summary>
		[IsRequired]
		[JsonProperty("purchaseOrderDate")]
		public DateTime PurchaseOrderDate { get; set; }

		/// <summary>
		/// The date when purchase order was last changed by Amazon after the order was placed
		/// This date will be greater than 'purchaseOrderDate'
		/// This means the PO data was changed on that date and vendors are required to fulfill the  updated PO
		/// The PO changes can be related to Item Quantity, Ship to Location, Ship Window etc
		/// This field will not be present in orders that have not changed after creation
		/// Must be in ISO-8601 date/time format
		/// </summary>
		[JsonProperty("purchaseOrderChangedDate")]
		public DateTime PurchaseOrderChangedDate { get; set; }

		/// <summary>
		/// The date when current purchase order state was changed
		/// Current purchase order state is available in the field 'purchaseOrderState'
		/// Must be in ISO-8601 date/time format
		/// </summary>
		[IsRequired]
		[JsonProperty("purchaseOrderStateChangedDate")]
		public DateTime PurchaseOrderStateChangedDate { get; set; }

		/// <summary>
		/// Type of purchase order
		/// </summary>
		[JsonProperty("purchaseOrderType")]
		public PurchaseOrderType PurchaseOrderType { get; set; }

		/// <summary>
		/// If the purchase order is an import order, the details for the import order
		/// </summary>
		[JsonProperty("importDetails")]
		public ImportDetails ImportDetails { get; set; }

		/// <summary>
		/// If requested by the recipient, this field will contain a promotional/deal number
		/// The discount code line is optional
		/// It is used to obtain a price discount on items on the order
		/// </summary>
		[JsonProperty("dealCode")]
		public string DealCode { get; set; }

		/// <summary>
		/// Payment method used
		/// </summary>
		[JsonProperty("paymentMethod")]
		public PaymentMethod PaymentMethod { get; set; }

		/// <summary>
		/// Name/Address and tax details of the buying party
		/// </summary>
		[JsonProperty("buyingParty")]
		public PartyIdentification BuyingParty { get; set; }

		/// <summary>
		/// Name/Address and tax details of the selling party
		/// </summary>
		[JsonProperty("sellingParty")]
		public PartyIdentification SellingParty { get; set; }

		/// <summary>
		/// Name/Address and tax details of the ship to party
		/// Find a list of fulfillment center addresses for a region on the [Resources page of Amazon Vendor Central](htt
		/// s://vendorcentral
		/// amazon
		/// com/hz/vendor/members/support/help/node/GPZ88XH8HQM97ZV6)
		/// </summary>
		[JsonProperty("shipToParty")]
		public PartyIdentification ShipToParty { get; set; }

		/// <summary>
		/// Name/Address and tax details of the bill to party
		/// </summary>
		[JsonProperty("billToParty")]
		public PartyIdentification BillToParty { get; set; }

		/// <summary>
		/// This indicates the ship window
		/// Format is start and end date separated by double hyphen (--)
		/// For example, 2007-03-01T13:00:00Z--2007-03-11T15:30:00Z
		/// </summary>
		[JsonProperty("shipWindow")]
		public DateTimeInterval ShipWindow { get; set; }

		/// <summary>
		/// This indicates the delivery window
		/// Format is start and end date separated by double hyphen (--)
		/// For example, 2007-03-01T13:00:00Z--2007-03-11T15:30:00Z
		/// </summary>
		[JsonProperty("deliveryWindow")]
		public DateTimeInterval DeliveryWindow { get; set; }

		/// <summary>
		/// A list of items in this purchase order
		/// </summary>
		[IsRequired]
		[JsonProperty("items")]
		public List<OrderItem> Items { get; set; }
	}
}
