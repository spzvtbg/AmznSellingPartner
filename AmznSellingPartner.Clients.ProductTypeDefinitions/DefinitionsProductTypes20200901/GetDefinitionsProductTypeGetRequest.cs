namespace AmznSellingPartner.Clients.ProductTypeDefinitions.DefinitionsProductTypes20200901
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	[HttpGet("/definitions/2020-09-01/productTypes/{productType}")]
	public class GetDefinitionsProductTypeGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The Amazon product type name
		/// </summary>
		[InPath("productType")]
		[IsRequired]
		[JsonProperty("productType")]
		public string ProductType { get; set; }

		/// <summary>
		/// A selling partner identifier
		/// When provided, seller-specific requirements and values are populated within the product type definition schem
		/// , such as brand names associated with the selling partner
		/// </summary>
		[InQuery("sellerId")]
		[JsonProperty("sellerId")]
		public string SellerId { get; set; }

		/// <summary>
		/// A comma-delimited list of Amazon marketplace identifiers for the request
		/// Note: This parameter is limited to one marketplaceId at this time
		/// </summary>
		[InQuery("marketplaceIds")]
		[IsRequired]
		[JsonProperty("marketplaceIds")]
		public CsvValue<string> MarketplaceIds { get; set; }

		/// <summary>
		/// The version of the Amazon product type to retrieve
		/// Defaults to "LATEST",
		/// Prerelease versions of product type definitions may be retrieved with "RELEASE_CANDIDATE"
		/// If no prerelease version is currently available, the "LATEST" live version will be provided
		/// </summary>
		[InQuery("productTypeVersion")]
		[JsonProperty("productTypeVersion")]
		public string ProductTypeVersion { get; set; }

		/// <summary>
		/// The name of the requirements set to retrieve requirements for
		/// </summary>
		[InQuery("requirements")]
		[JsonProperty("requirements")]
		public Requirements Requirements { get; set; }

		/// <summary>
		/// Identifies if the required attributes for a requirements set are enforced by the product type definition schem
		/// 
		/// Non-enforced requirements enable structural validation of individual attributes without all the required attr
		/// butes being present (such as for partial updates)
		/// </summary>
		[InQuery("requirementsEnforced")]
		[JsonProperty("requirementsEnforced")]
		public RequirementsEnforced RequirementsEnforced { get; set; }

		/// <summary>
		/// Locale for retrieving display labels and other presentation details
		/// Defaults to the default language of the first marketplace in the request
		/// </summary>
		[InQuery("locale")]
		[JsonProperty("locale")]
		public Locale Locale { get; set; }
	}
}
