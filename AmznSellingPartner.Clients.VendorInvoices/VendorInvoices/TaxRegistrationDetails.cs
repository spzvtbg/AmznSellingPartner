namespace AmznSellingPartner.Clients.VendorInvoices.VendorInvoices
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Tax registration details of the entity.
	/// </summary>
	public class TaxRegistrationDetails : BaseClass
	{
		/// <summary>
		/// The tax registration type for the entity.
		/// </summary>
		[JsonProperty("taxRegistrationType")]
		[IsRequired]
		public TaxRegistrationType TaxRegistrationType { get; set; } 

		/// <summary>
		/// The tax registration number for the entity. For example, VAT ID, Consumption Tax ID.
		/// </summary>
		[JsonProperty("taxRegistrationNumber")]
		[IsRequired]
		public string TaxRegistrationNumber { get; set; } 
	}
}
