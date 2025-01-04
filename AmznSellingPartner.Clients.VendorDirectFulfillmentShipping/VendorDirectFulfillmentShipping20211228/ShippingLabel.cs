namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Shipping label information for an order, including the purchase order number, selling party, ship from
	/// party, label format, and package details.
	/// </summary>
	public class ShippingLabel : BaseClass
	{
		/// <summary>
		/// This field will contain the Purchase Order Number for this order.
		/// </summary>
		[JsonProperty("purchaseOrderNumber")]
		[IsRequired]
		[Pattern("^[a-zA-Z0-9]+")]
		public string PurchaseOrderNumber { get; set; } 

		/// <summary>
		/// ID of the selling party or vendor.
		/// </summary>
		[JsonProperty("sellingParty")]
		[IsRequired]
		public PartyIdentification SellingParty { get; set; } 

		/// <summary>
		/// Warehouse code of vendor.
		/// </summary>
		[JsonProperty("shipFromParty")]
		[IsRequired]
		public PartyIdentification ShipFromParty { get; set; } 

		/// <summary>
		/// Format of the label.
		/// </summary>
		[JsonProperty("labelFormat")]
		[IsRequired]
		public LabelFormat LabelFormat { get; set; } 

		/// <summary>
		/// Provides the details of the packages in this shipment.
		/// </summary>
		[JsonProperty("labelData")]
		[IsRequired]
		public List<LabelData> LabelData { get; set; } 
	}
}
