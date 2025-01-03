namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Name, address and tax details of a party
	/// </summary>
	public class PartyIdentification : BaseClass
	{
		/// <summary>
		/// Assigned identification for the party
		/// For example, warehouse code or vendor code
		/// Please refer to specific party for more details
		/// </summary>
		[IsRequired]
		[JsonProperty("partyId")]
		public string PartyId { get; set; }

		/// <summary>
		/// Address details of the party
		/// </summary>
		[JsonProperty("address")]
		public Address Address { get; set; }

		/// <summary>
		/// Tax registration details of the entity
		/// </summary>
		[JsonProperty("taxInfo")]
		public TaxRegistrationDetails TaxInfo { get; set; }
	}
}
