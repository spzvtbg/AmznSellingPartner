namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Name/Address and tax details of the party.
	/// </summary>
	public class PartyIdentification : BaseClass
	{
		/// <summary>
		/// Identification of the party by address.
		/// </summary>
		[JsonProperty("address")]
		public Address Address { get; set; } 

		/// <summary>
		/// Assigned identification for the party.
		/// </summary>
		[JsonProperty("partyId")]
		[IsRequired]
		public string PartyId { get; set; } 

		/// <summary>
		/// Tax registration details of the entity.
		/// </summary>
		[JsonProperty("taxRegistrationDetails")]
		public List<TaxRegistrationDetails> TaxRegistrationDetails { get; set; } 
	}
}
