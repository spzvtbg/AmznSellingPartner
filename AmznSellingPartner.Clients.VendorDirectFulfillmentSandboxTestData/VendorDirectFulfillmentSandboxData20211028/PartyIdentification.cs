namespace AmznSellingPartner.Clients.VendorDirectFulfillmentSandboxTestData.VendorDirectFulfillmentSandboxData20211028
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The identification object for the party information. For example, warehouse code or vendor code. Please
	/// refer to specific party for more details.
	/// </summary>
	public class PartyIdentification : BaseClass
	{
		/// <summary>
		/// Assigned identification for the party. For example, warehouse code or vendor code. Please refer to specific
		/// party for more details.
		/// </summary>
		[IsRequired]
		[JsonProperty("partyId")]
		public string PartyId { get; set; }
	}
}
