namespace AmznSellingPartner.Clients.ProductTypeDefinitions.DefinitionsProductTypes20200901
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    [HttpGet("/definitions/2020-09-01/productTypes/{productType}")]
    public class AmznGetDefinitionsProductTypeRequest : BaseHttpRequest
    {
        /// <summary>
        /// The Amazon product type name.
        /// </summary>
        [InPath("productType")]
        [IsRequired]
        public string ProductType { get; set; }

        /// <summary>
        /// A selling partner identifier. When provided, seller-specific requirements and values are populated
        /// within the product type definition schema, such as brand names associated with the selling
        /// partner.
        /// </summary>
        [InQuery("sellerId")]
        public string SellerId { get; set; }

        /// <summary>
        /// A comma-delimited list of Amazon marketplace identifiers for the request. Note: This parameter
        /// is limited to one marketplaceId at this time.
        /// </summary>
        [InQuery("marketplaceIds")]
        [IsRequired]
        public CsvValue<string> MarketplaceIds { get; set; }

        /// <summary>
        /// The version of the Amazon product type to retrieve. Defaults to "LATEST",. Prerelease versions
        /// of product type definitions may be retrieved with "RELEASE_CANDIDATE". If no prerelease version
        /// is currently available, the "LATEST" live version will be provided.
        /// </summary>
        [InQuery("productTypeVersion")]
        public string ProductTypeVersion { get; set; } = "LATEST";

        /// <summary>
        /// The name of the requirements set to retrieve requirements for.
        /// </summary>
        [InQuery("requirements")]
        public Requirements Requirements { get; set; } = Requirements.LISTING;

        /// <summary>
        /// Identifies if the required attributes for a requirements set are enforced by the product type
        /// definition schema. Non-enforced requirements enable structural validation of individual attributes
        /// without all the required attributes being present (such as for partial updates).
        /// </summary>
        [InQuery("requirementsEnforced")]
        public RequirementsEnforced RequirementsEnforced { get; set; } = RequirementsEnforced.ENFORCED;

        /// <summary>
        /// Locale for retrieving display labels and other presentation details. Defaults to the default
        /// language of the first marketplace in the request.
        /// </summary>
        [InQuery("locale")]
        public Locale Locale { get; set; } = Locale.DEFAULT;
    }
}
