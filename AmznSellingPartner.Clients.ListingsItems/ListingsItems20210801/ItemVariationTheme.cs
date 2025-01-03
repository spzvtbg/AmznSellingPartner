namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// A variation theme that indicates the combination of listing item attributes that define the variation family
	/// </summary>
	public class ItemVariationTheme : BaseClass
	{
		/// <summary>
		/// The names of the listing item attributes that are associated with the variation theme
		/// </summary>
		[IsRequired]
		[JsonProperty("attributes")]
		public List<string> Attributes { get; set; }

		/// <summary>
		/// The variation theme that indicates the combination of listing item attributes that define the variation family
		/// </summary>
		[IsRequired]
		[JsonProperty("theme")]
		public string Theme { get; set; }
	}
}
