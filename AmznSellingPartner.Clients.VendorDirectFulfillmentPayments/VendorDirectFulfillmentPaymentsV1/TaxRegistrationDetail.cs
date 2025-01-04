namespace AmznSellingPartner.Clients.VendorDirectFulfillmentPayments.VendorDirectFulfillmentPaymentsV1
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Tax registration details of the entity.
	/// </summary>
	public class TaxRegistrationDetail : BaseClass
	{
		/// <summary>
		/// Tax registration type for the entity.
		/// </summary>
		[JsonProperty("taxRegistrationType")]
		public TaxRegistrationType TaxRegistrationType { get; set; }

		/// <summary>
		/// Tax registration number for the entity. For example, VAT ID, Consumption Tax ID.
		/// </summary>
		[JsonProperty("taxRegistrationNumber")]
		[IsRequired]
		public string TaxRegistrationNumber { get; set; }

		/// <summary>
		/// Address associated with the tax registration number.
		/// </summary>
		[JsonProperty("taxRegistrationAddress")]
		public Address TaxRegistrationAddress { get; set; }

		/// <summary>
		/// Tax registration message that can be used for additional tax related details.
		/// </summary>
		[JsonProperty("taxRegistrationMessage")]
		public string TaxRegistrationMessage { get; set; }
	}
}
