namespace AmznSellingPartner.Clients.VendorDirectFulfillmentInventory.VendorDirectFulfillmentInventoryV1
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
		/// </summary>
		[IsRequired]
		[JsonProperty("partyId")]
		public string PartyId { get; set; }
	}
}
