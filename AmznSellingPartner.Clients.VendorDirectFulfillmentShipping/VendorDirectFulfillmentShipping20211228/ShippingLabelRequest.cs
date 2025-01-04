namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Represents the request payload for creating a shipping label, containing the purchase order number, selling
	/// party, ship from party, and a list of containers or packages in the shipment.
	/// </summary>
	public class ShippingLabelRequest : BaseClass
	{
		/// <summary>
		/// The purchase order number of the order for which to create a shipping label.
		/// </summary>
		[JsonProperty("purchaseOrderNumber")]
		[IsRequired]
		[Pattern("^[a-zA-Z0-9]+")]
		public string PurchaseOrderNumber { get; set; }

		/// <summary>
		/// The ID of the selling party or vendor.
		/// </summary>
		[JsonProperty("sellingParty")]
		[IsRequired]
		public PartyIdentification SellingParty { get; set; }

		/// <summary>
		/// The warehouse code of the vendor.
		/// </summary>
		[JsonProperty("shipFromParty")]
		[IsRequired]
		public PartyIdentification ShipFromParty { get; set; }

		/// <summary>
		/// A list of the packages in this shipment.
		/// </summary>
		[JsonProperty("containers")]
		public List<Container> Containers { get; set; }
	}
}
