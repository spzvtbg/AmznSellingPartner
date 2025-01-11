namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// the relationship details for a listing item.
	/// </summary>
	public class ItemRelationship : BaseClass
	{
		/// <summary>
		/// Identifiers (SKUs) of the related items that are children of this listing item.
		/// </summary>
		[JsonProperty("childSkus")]
		public List<string> ChildSkus { get; set; } 

		/// <summary>
		/// Identifiers (SKUs) of the related items that are parents of this listing item.
		/// </summary>
		[JsonProperty("parentSkus")]
		public List<string> ParentSkus { get; set; } 

		/// <summary>
		/// For `VARIATION` relationships, the variation theme is the combination of listing item attributes
		/// that define the variation family.
		/// </summary>
		[JsonProperty("variationTheme")]
		public ItemVariationTheme VariationTheme { get; set; } 

		/// <summary>
		/// The type of relationship.
		/// </summary>
		[JsonProperty("type")]
		[IsRequired]
		public Type Type { get; set; } 
	}
}
