namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Relationship details for an Amazon catalog item.
	/// </summary>
	public class ItemRelationship : BaseClass
	{
		/// <summary>
		/// Identifiers (ASINs) of the related items that are children of this item.
		/// </summary>
		[JsonProperty("childAsins")]
		public List<string> ChildAsins { get; set; }

		/// <summary>
		/// Identifiers (ASINs) of the related items that are parents of this item.
		/// </summary>
		[JsonProperty("parentAsins")]
		public List<string> ParentAsins { get; set; }

		/// <summary>
		/// For "VARIATION" relationships, variation theme indicating the combination of Amazon item catalog attributes th
		/// t define the variation family.
		/// </summary>
		[JsonProperty("variationTheme")]
		public ItemVariationTheme VariationTheme { get; set; }

		/// <summary>
		/// Type of relationship.
		/// </summary>
		[IsRequired]
		[JsonProperty("type")]
		public Type Type { get; set; }
	}
}
