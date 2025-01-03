namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;

	/// <summary>
	/// Vendor Details as part of Label response.
	/// </summary>
	public class VendorDetails : BaseClass
	{
		/// <summary>
		/// Name/Address and tax details of the selling party.
		/// </summary>
		[JsonProperty("sellingParty")]
		public PartyIdentification SellingParty { get; set; }

		/// <summary>
		/// Unique vendor shipment id which is not used in last 365 days
		/// </summary>
		[JsonProperty("vendorShipmentIdentifier")]
		public string VendorShipmentIdentifier { get; set; }
	}
}
