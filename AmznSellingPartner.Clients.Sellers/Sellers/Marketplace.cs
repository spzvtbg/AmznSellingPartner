namespace AmznSellingPartner.Clients.Sellers.Sellers
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Detailed information about an Amazon market where a seller can list items for sale and customers can view and
	/// urchase items.
	/// </summary>
	public class Marketplace : BaseClass
	{
		/// <summary>
		/// The encrypted marketplace value.
		/// </summary>
		[IsRequired]
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// Marketplace name.
		/// </summary>
		[IsRequired]
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// The ISO 3166-1 alpha-2 format country code of the marketplace.
		/// </summary>
		[IsRequired]
		[Pattern("^([A-Z]{2})")]
		[JsonProperty("countryCode")]
		public string CountryCode { get; set; }

		/// <summary>
		/// The ISO 4217 format currency code of the marketplace.
		/// </summary>
		[IsRequired]
		[JsonProperty("defaultCurrencyCode")]
		public string DefaultCurrencyCode { get; set; }

		/// <summary>
		/// The ISO 639-1 format language code of the marketplace.
		/// </summary>
		[IsRequired]
		[JsonProperty("defaultLanguageCode")]
		public string DefaultLanguageCode { get; set; }

		/// <summary>
		/// The domain name of the marketplace.
		/// </summary>
		[IsRequired]
		[JsonProperty("domainName")]
		public string DomainName { get; set; }
	}
}
