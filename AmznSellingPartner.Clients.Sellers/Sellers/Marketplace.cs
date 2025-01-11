namespace AmznSellingPartner.Clients.Sellers.Sellers
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Detailed information about an Amazon market where a seller can list items for sale and customers
	/// can view and purchase items.
	/// </summary>
	public class Marketplace : BaseClass
	{
		/// <summary>
		/// The encrypted marketplace value.
		/// </summary>
		[JsonProperty("id")]
		[IsRequired]
		public string Id { get; set; } 

		/// <summary>
		/// Marketplace name.
		/// </summary>
		[JsonProperty("name")]
		[IsRequired]
		public string Name { get; set; } 

		/// <summary>
		/// The ISO 3166-1 alpha-2 format country code of the marketplace.
		/// </summary>
		[JsonProperty("countryCode")]
		[IsRequired]
		[Pattern("^([A-Z]{2})")]
		public string CountryCode { get; set; } 

		/// <summary>
		/// The ISO 4217 format currency code of the marketplace.
		/// </summary>
		[JsonProperty("defaultCurrencyCode")]
		[IsRequired]
		public string DefaultCurrencyCode { get; set; } 

		/// <summary>
		/// The ISO 639-1 format language code of the marketplace.
		/// </summary>
		[JsonProperty("defaultLanguageCode")]
		[IsRequired]
		public string DefaultLanguageCode { get; set; } 

		/// <summary>
		/// The domain name of the marketplace.
		/// </summary>
		[JsonProperty("domainName")]
		[IsRequired]
		public string DomainName { get; set; } 
	}
}
