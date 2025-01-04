namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Search refinements.
	/// </summary>
	public class Refinements : BaseClass
	{
		/// <summary>
		/// Brand search refinements.
		/// </summary>
		[JsonProperty("brands")]
		[IsRequired]
		public List<BrandRefinement> Brands { get; set; }

		/// <summary>
		/// Classification search refinements.
		/// </summary>
		[JsonProperty("classifications")]
		[IsRequired]
		public List<ClassificationRefinement> Classifications { get; set; }
	}
}
