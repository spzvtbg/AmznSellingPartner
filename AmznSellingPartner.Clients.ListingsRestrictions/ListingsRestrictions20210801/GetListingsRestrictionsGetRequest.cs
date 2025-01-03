namespace AmznSellingPartner.Clients.ListingsRestrictions.ListingsRestrictions20210801
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	[HttpGet("/listings/2021-08-01/restrictions")]
	public class GetListingsRestrictionsGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The Amazon Standard Identification Number (ASIN) of the item.
		/// </summary>
		[InQuery("asin")]
		[IsRequired]
		[JsonProperty("asin")]
		public string Asin { get; set; }

		/// <summary>
		/// The condition used to filter restrictions.
		/// </summary>
		[InQuery("conditionType")]
		[JsonProperty("conditionType")]
		public ConditionType ConditionType { get; set; }

		/// <summary>
		/// A selling partner identifier, such as a merchant account.
		/// </summary>
		[InQuery("sellerId")]
		[IsRequired]
		[JsonProperty("sellerId")]
		public string SellerId { get; set; }

		/// <summary>
		/// A comma-delimited list of Amazon marketplace identifiers for the request.
		/// </summary>
		[InQuery("marketplaceIds")]
		[IsRequired]
		[JsonProperty("marketplaceIds")]
		public CsvValue<string> MarketplaceIds { get; set; }

		/// <summary>
		/// A locale for reason text localization. When not provided, the default language code of the first marketplace i
		/// used. Examples: "en_US", "fr_CA", "fr_FR". Localized messages default to "en_US" when a localization is not a
		/// ailable in the specified locale.
		/// </summary>
		[InQuery("reasonLocale")]
		[JsonProperty("reasonLocale")]
		public string ReasonLocale { get; set; }
	}
}
