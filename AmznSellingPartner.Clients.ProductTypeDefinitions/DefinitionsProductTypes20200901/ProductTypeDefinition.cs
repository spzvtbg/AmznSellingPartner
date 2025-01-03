namespace AmznSellingPartner.Clients.ProductTypeDefinitions.DefinitionsProductTypes20200901
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// A product type definition represents the attributes and data requirements for a product type in the Amazon cat
	/// log. Product type definitions are used interchangeably between the Selling Partner API for Listings Items, Sel
	/// ing Partner API for Catalog Items, and JSON-based listings feeds in the Selling Partner API for Feeds.
	/// </summary>
	public class ProductTypeDefinition : BaseClass
	{
		/// <summary>
		/// Link to meta-schema describing the vocabulary used by the product type schema.
		/// </summary>
		[JsonProperty("metaSchema")]
		public SchemaLink MetaSchema { get; set; }

		/// <summary>
		/// Link to schema describing the attributes and requirements for the product type.
		/// </summary>
		[IsRequired]
		[JsonProperty("schema")]
		public SchemaLink Schema { get; set; }

		/// <summary>
		/// Name of the requirements set represented in this product type definition.
		/// </summary>
		[IsRequired]
		[JsonProperty("requirements")]
		public Requirements Requirements { get; set; }

		/// <summary>
		/// Identifies if the required attributes for a requirements set are enforced by the product type definition schem
		/// . Non-enforced requirements enable structural validation of individual attributes without all of the required
		/// ttributes being present (such as for partial updates).
		/// </summary>
		[IsRequired]
		[JsonProperty("requirementsEnforced")]
		public RequirementsEnforced RequirementsEnforced { get; set; }

		/// <summary>
		/// Mapping of property group names to property groups. Property groups represent logical groupings of schema prop
		/// rties that can be used for display or informational purposes.
		/// </summary>
		[IsRequired]
		[JsonProperty("propertyGroups")]
		public PropertyGroups PropertyGroups { get; set; }

		/// <summary>
		/// Locale of the display elements contained in the product type definition.
		/// </summary>
		[IsRequired]
		[JsonProperty("locale")]
		public string Locale { get; set; }

		/// <summary>
		/// Amazon marketplace identifiers for which the product type definition is applicable.
		/// </summary>
		[IsRequired]
		[JsonProperty("marketplaceIds")]
		public List<string> MarketplaceIds { get; set; }

		/// <summary>
		/// The name of the Amazon product type that this product type definition applies to.
		/// </summary>
		[IsRequired]
		[JsonProperty("productType")]
		public string ProductType { get; set; }

		/// <summary>
		/// Human-readable and localized description of the Amazon product type.
		/// </summary>
		[IsRequired]
		[JsonProperty("displayName")]
		public string DisplayName { get; set; }

		/// <summary>
		/// The version details for the Amazon product type.
		/// </summary>
		[IsRequired]
		[JsonProperty("productTypeVersion")]
		public ProductTypeVersion ProductTypeVersion { get; set; }
	}
}
