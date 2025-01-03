namespace AmznSellingPartner.Clients.ProductTypeDefinitions.DefinitionsProductTypes20200901
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// An Amazon product type with a definition available.
	/// </summary>
	public class ProductType : BaseClass
	{
		/// <summary>
		/// The name of the Amazon product type.
		/// </summary>
		[IsRequired]
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// The human-readable and localized description of the Amazon product type.
		/// </summary>
		[IsRequired]
		[JsonProperty("displayName")]
		public string DisplayName { get; set; }

		/// <summary>
		/// The Amazon marketplace identifiers for which the product type definition is available.
		/// </summary>
		[IsRequired]
		[JsonProperty("marketplaceIds")]
		public List<string> MarketplaceIds { get; set; }
	}
}
