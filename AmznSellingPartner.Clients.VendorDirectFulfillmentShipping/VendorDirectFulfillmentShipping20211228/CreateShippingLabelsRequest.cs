namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The request body for the createShippingLabels operation
	/// </summary>
	public class CreateShippingLabelsRequest : BaseClass
	{
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
		/// A list of the packages in this shipment
		/// </summary>
		[JsonProperty("containers")]
		public List<Container> Containers { get; set; }
	}
}
