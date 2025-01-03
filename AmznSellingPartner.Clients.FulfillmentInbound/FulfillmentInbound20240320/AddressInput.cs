namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Specific details to identify a place
	/// </summary>
	public class AddressInput : BaseClass
	{
		/// <summary>
		/// Street address information
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(180)]
		[JsonProperty("addressLine1")]
		public string AddressLine1 { get; set; }

		/// <summary>
		/// Additional street address information
		/// </summary>
		[MinLength(1)]
		[MaxLength(60)]
		[JsonProperty("addressLine2")]
		public string AddressLine2 { get; set; }

		/// <summary>
		/// The city
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(30)]
		[JsonProperty("city")]
		public string City { get; set; }

		/// <summary>
		/// The name of the business
		/// </summary>
		[MinLength(1)]
		[MaxLength(50)]
		[JsonProperty("companyName")]
		public string CompanyName { get; set; }

		/// <summary>
		/// The country code in two-character ISO 3166-1 alpha-2 format
		/// </summary>
		[IsRequired]
		[Pattern("^[A-Z]{2}")]
		[MinLength(2)]
		[MaxLength(2)]
		[JsonProperty("countryCode")]
		public string CountryCode { get; set; }

		/// <summary>
		/// The email address
		/// </summary>
		[MinLength(1)]
		[MaxLength(1024)]
		[JsonProperty("email")]
		public string Email { get; set; }

		/// <summary>
		/// The name of the individual who is the primary contact
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(50)]
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// The phone number
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(20)]
		[JsonProperty("phoneNumber")]
		public string PhoneNumber { get; set; }

		/// <summary>
		/// The postal code
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(32)]
		[JsonProperty("postalCode")]
		public string PostalCode { get; set; }

		/// <summary>
		/// The state or province code
		/// </summary>
		[MinLength(1)]
		[MaxLength(64)]
		[JsonProperty("stateOrProvinceCode")]
		public string StateOrProvinceCode { get; set; }
	}
}
