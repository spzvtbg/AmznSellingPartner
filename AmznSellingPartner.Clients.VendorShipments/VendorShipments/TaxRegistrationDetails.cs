namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Tax registration details of the entity.
	/// </summary>
	public class TaxRegistrationDetails : BaseClass
	{
		/// <summary>
		/// Tax registration type for the entity.
		/// </summary>
		[JsonProperty("taxRegistrationType")]
		[IsRequired]
		public TaxRegistrationType TaxRegistrationType { get; set; } 

		/// <summary>
		/// Tax registration number for the entity. For example, VAT ID.
		/// </summary>
		[JsonProperty("taxRegistrationNumber")]
		[IsRequired]
		public string TaxRegistrationNumber { get; set; } 
	}
}
