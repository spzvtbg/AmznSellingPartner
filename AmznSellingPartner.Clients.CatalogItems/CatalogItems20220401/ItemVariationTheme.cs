namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Variation theme indicating the combination of Amazon item catalog attributes that define the variation family.
	/// </summary>
	public class ItemVariationTheme : BaseClass
	{
		/// <summary>
		/// Names of the Amazon catalog item attributes associated with the variation theme.
		/// </summary>
		[JsonProperty("attributes")]
		public List<string> Attributes { get; set; }

		/// <summary>
		/// Variation theme indicating the combination of Amazon item catalog attributes that define the variation family.
		/// </summary>
		[JsonProperty("theme")]
		public string Theme { get; set; }
	}
}
