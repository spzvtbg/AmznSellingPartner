namespace AmznSellingPartner.Clients.Sellers.Sellers
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Information about the Seller's business. These fields may be omitted if the Seller is registered as an
	/// individual.
	/// </summary>
	public class Business : BaseClass
	{
		/// <summary>
		/// The registered business name.
		/// </summary>
		[IsRequired]
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// The registered business address.
		/// </summary>
		[IsRequired]
		[JsonProperty("registeredBusinessAddress")]
		public Address RegisteredBusinessAddress { get; set; }

		/// <summary>
		/// The seller's company registration number, if applicable. This field will be absent for individual sellers
		/// and sole proprietorships.
		/// </summary>
		[JsonProperty("companyRegistrationNumber")]
		public string CompanyRegistrationNumber { get; set; }

		/// <summary>
		/// The seller's company tax identification number, if applicable. This field will be present for certain
		/// business types only, such as sole proprietorships.
		/// </summary>
		[JsonProperty("companyTaxIdentificationNumber")]
		public string CompanyTaxIdentificationNumber { get; set; }

		/// <summary>
		/// The non-Latin script version of the registered business name, if applicable.
		/// </summary>
		[JsonProperty("nonLatinName")]
		public string NonLatinName { get; set; }
	}
}
