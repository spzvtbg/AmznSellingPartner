namespace AmznSellingPartner.Clients.VendorDirectFulfillmentPayments.VendorDirectFulfillmentPaymentsV1
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
		/// Assigned Identification for the party.
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
		/// Tax registration details of the entity.
		/// </summary>
		[JsonProperty("taxRegistrationDetails")]
		public List<TaxRegistrationDetail> TaxRegistrationDetails { get; set; }
	}
}
