namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Tax registration details of the entity
	/// </summary>
	public class TaxRegistrationDetails : BaseClass
	{
		/// <summary>
		/// Tax registration type for the entity
		/// </summary>
		[IsRequired]
		[JsonProperty("taxRegistrationType")]
		public TaxRegistrationType TaxRegistrationType { get; set; }

		/// <summary>
		/// Tax registration number for the entity
		/// For example, VAT ID
		/// </summary>
		[IsRequired]
		[JsonProperty("taxRegistrationNumber")]
		public string TaxRegistrationNumber { get; set; }
	}
}
