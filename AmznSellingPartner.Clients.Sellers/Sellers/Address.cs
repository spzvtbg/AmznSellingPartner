namespace AmznSellingPartner.Clients.Sellers.Sellers
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Represents an address
	/// </summary>
	public class Address : BaseClass
	{
		/// <summary>
		/// Street address information.
		/// </summary>
		[JsonProperty("addressLine1")]
		[IsRequired]
		public string AddressLine1 { get; set; }

		/// <summary>
		/// Additional street address information.
		/// </summary>
		[JsonProperty("addressLine2")]
		public string AddressLine2 { get; set; }

		/// <summary>
		/// The country code in two-character ISO 3166-1 alpha-2 format.
		/// </summary>
		[JsonProperty("countryCode")]
		[IsRequired]
		public string CountryCode { get; set; }

		/// <summary>
		/// The state or province code.
		/// </summary>
		[JsonProperty("stateOrProvinceCode")]
		public string StateOrProvinceCode { get; set; }

		/// <summary>
		/// The city.
		/// </summary>
		[JsonProperty("city")]
		public string City { get; set; }

		/// <summary>
		/// The postal code.
		/// </summary>
		[JsonProperty("postalCode")]
		public string PostalCode { get; set; }
	}
}
