namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Represents the confirmation details of a shipment, including the purchase order number and other shipment
	/// details.
	/// </summary>
	public class ShipmentConfirmation : BaseClass
	{
		/// <summary>
		/// Purchase order number corresponding to the shipment.
		/// </summary>
		[JsonProperty("purchaseOrderNumber")]
		[IsRequired]
		[Pattern("^[a-zA-Z0-9]+")]
		public string PurchaseOrderNumber { get; set; }

		/// <summary>
		/// Shipment information.
		/// </summary>
		[JsonProperty("shipmentDetails")]
		[IsRequired]
		public ShipmentDetails ShipmentDetails { get; set; }

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
		/// Provide the details of the items in this shipment. If any of the item details field is common at a package
		/// or a pallet level, then provide them at the corresponding package.
		/// </summary>
		[JsonProperty("items")]
		[IsRequired]
		public List<Item> Items { get; set; }

		/// <summary>
		/// Provide the details of the items in this shipment. If any of the item details field is common at a package
		/// or a pallet level, then provide them at the corresponding package.
		/// </summary>
		[JsonProperty("containers")]
		public List<Container> Containers { get; set; }
	}
}
