namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Shipping label information for an order, including the purchase order number, selling party, ship from party,
	/// abel format, and package details
	/// </summary>
	public class ShippingLabel : BaseClass
	{
		/// <summary>
		/// This field will contain the Purchase Order Number for this order
		/// </summary>
		[IsRequired]
		[Pattern("^[a-zA-Z0-9]+")]
		[JsonProperty("purchaseOrderNumber")]
		public string PurchaseOrderNumber { get; set; }

		/// <summary>
		/// ID of the selling party or vendor
		/// </summary>
		[IsRequired]
		[JsonProperty("sellingParty")]
		public PartyIdentification SellingParty { get; set; }

		/// <summary>
		/// Warehouse code of vendor
		/// </summary>
		[IsRequired]
		[JsonProperty("shipFromParty")]
		public PartyIdentification ShipFromParty { get; set; }

		/// <summary>
		/// Format of the label
		/// </summary>
		[IsRequired]
		[JsonProperty("labelFormat")]
		public LabelFormat LabelFormat { get; set; }

		/// <summary>
		/// Provides the details of the packages in this shipment
		/// </summary>
		[IsRequired]
		[JsonProperty("labelData")]
		public List<LabelData> LabelData { get; set; }
	}
}
