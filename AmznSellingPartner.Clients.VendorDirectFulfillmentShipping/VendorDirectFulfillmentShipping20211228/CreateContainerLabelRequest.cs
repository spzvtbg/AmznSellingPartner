namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The request body schema for the `createContainerLabel` operation.
	/// </summary>
	public class CreateContainerLabelRequest : BaseClass
	{
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
		/// The container (pallet) label's carrier.
		/// </summary>
		[JsonProperty("carrierId")]
		[IsRequired]
		public CarrierId CarrierId { get; set; } 

		/// <summary>
		/// The vendor's unique identifier for the container.
		/// </summary>
		[JsonProperty("vendorContainerId")]
		[IsRequired]
		public VendorContainerId VendorContainerId { get; set; } 

		/// <summary>
		/// An array of package objects that associates shipment packages with a container.
		/// </summary>
		[JsonProperty("packages")]
		[IsRequired]
		public Packages Packages { get; set; } 
	}
}
