namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Name, address and tax details of a party.
	/// </summary>
	public class PartyIdentification : BaseClass
	{
		/// <summary>
		/// Assigned identification for the party. For example, warehouse code or vendor code. Please refer to specific pa
		/// ty for more details.
		/// </summary>
		[IsRequired]
		[JsonProperty("partyId")]
		public string PartyId { get; set; }

		/// <summary>
		/// Identification of the party by address.
		/// </summary>
		[JsonProperty("address")]
		public Address Address { get; set; }

		/// <summary>
		/// Tax registration details of the party.
		/// </summary>
		[JsonProperty("taxInfo")]
		public TaxRegistrationDetails TaxInfo { get; set; }
	}
}
