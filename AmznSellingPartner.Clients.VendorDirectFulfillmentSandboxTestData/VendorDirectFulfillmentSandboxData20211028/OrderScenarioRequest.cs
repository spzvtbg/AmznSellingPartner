namespace AmznSellingPartner.Clients.VendorDirectFulfillmentSandboxTestData.VendorDirectFulfillmentSandboxData20211028
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The party identifiers required to generate the test data.
	/// </summary>
	public class OrderScenarioRequest : BaseClass
	{
		/// <summary>
		/// The identifier of the selling party or vendor.
		/// </summary>
		[IsRequired]
		[JsonProperty("sellingParty")]
		public PartyIdentification SellingParty { get; set; }

		/// <summary>
		/// The warehouse code of the vendor.
		/// </summary>
		[IsRequired]
		[JsonProperty("shipFromParty")]
		public PartyIdentification ShipFromParty { get; set; }
	}
}
