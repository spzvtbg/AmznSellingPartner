namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Represents the confirmation details of a shipment, including the purchase order number and other shipment deta
	/// ls
	/// </summary>
	public class ShipmentConfirmation : BaseClass
	{
		/// <summary>
		/// Purchase order number corresponding to the shipment
		/// </summary>
		[IsRequired]
		[Pattern("^[a-zA-Z0-9]+")]
		[JsonProperty("purchaseOrderNumber")]
		public string PurchaseOrderNumber { get; set; }

		/// <summary>
		/// Shipment information
		/// </summary>
		[IsRequired]
		[JsonProperty("shipmentDetails")]
		public ShipmentDetails ShipmentDetails { get; set; }

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
		/// Provide the details of the items in this shipment
		/// If any of the item details field is common at a package or a pallet level, then provide them at the correspon
		/// ing package
		/// </summary>
		[IsRequired]
		[JsonProperty("items")]
		public List<Item> Items { get; set; }

		/// <summary>
		/// Provide the details of the items in this shipment
		/// If any of the item details field is common at a package or a pallet level, then provide them at the correspon
		/// ing package
		/// </summary>
		[JsonProperty("containers")]
		public List<Container> Containers { get; set; }
	}
}
