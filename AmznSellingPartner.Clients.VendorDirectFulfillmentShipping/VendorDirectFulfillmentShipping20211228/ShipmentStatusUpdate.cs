namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Represents an update to the status of a shipment.
	/// </summary>
	public class ShipmentStatusUpdate : BaseClass
	{
		/// <summary>
		/// Purchase order number of the shipment for which to update the shipment status.
		/// </summary>
		[IsRequired]
		[Pattern("^[a-zA-Z0-9]+")]
		[JsonProperty("purchaseOrderNumber")]
		public string PurchaseOrderNumber { get; set; }

		/// <summary>
		/// ID of the selling party or vendor.
		/// </summary>
		[IsRequired]
		[JsonProperty("sellingParty")]
		public PartyIdentification SellingParty { get; set; }

		/// <summary>
		/// Warehouse code of vendor.
		/// </summary>
		[IsRequired]
		[JsonProperty("shipFromParty")]
		public PartyIdentification ShipFromParty { get; set; }

		/// <summary>
		/// Provide the details about the status of the shipment at that particular point of time.
		/// </summary>
		[IsRequired]
		[JsonProperty("statusUpdateDetails")]
		public StatusUpdateDetails StatusUpdateDetails { get; set; }
	}
}
