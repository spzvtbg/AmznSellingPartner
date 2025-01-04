namespace AmznSellingPartner.Clients.VendorInvoices.VendorInvoices
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Name, address and tax details of a party.
	/// </summary>
	public class PartyIdentification : BaseClass
	{
		/// <summary>
		/// Assigned identification for the party.
		/// </summary>
		[JsonProperty("partyId")]
		[IsRequired]
		public string PartyId { get; set; } 

		/// <summary>
		/// Identification of the party by address.
		/// </summary>
		[JsonProperty("address")]
		public Address Address { get; set; } 

		/// <summary>
		/// Tax registration details of the party.
		/// </summary>
		[JsonProperty("taxRegistrationDetails")]
		public List<TaxRegistrationDetails> TaxRegistrationDetails { get; set; } 
	}
}
