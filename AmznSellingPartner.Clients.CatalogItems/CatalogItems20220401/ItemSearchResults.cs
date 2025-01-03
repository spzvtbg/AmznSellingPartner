namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Items in the Amazon catalog and search related metadata.
	/// </summary>
	public class ItemSearchResults : BaseClass
	{
		/// <summary>
		/// For `identifiers`-based searches, the total number of Amazon catalog items found. For `keywords`-based searche
		/// , the estimated total number of Amazon catalog items matched by the search query (only results up to the page
		/// ount limit will be returned per request regardless of the number found).  Note: The maximum number of items (A
		/// INs) that can be returned and paged through is 1000.
		/// </summary>
		[IsRequired]
		[JsonProperty("numberOfResults")]
		public int NumberOfResults { get; set; }

		/// <summary>
		/// If available, the `nextToken` and/or `previousToken` values required to return paginated results.
		/// </summary>
		[IsRequired]
		[JsonProperty("pagination")]
		public Pagination Pagination { get; set; }

		/// <summary>
		/// Search refinements for `keywords`-based searches.
		/// </summary>
		[IsRequired]
		[JsonProperty("refinements")]
		public Refinements Refinements { get; set; }

		/// <summary>
		/// A list of items from the Amazon catalog.
		/// </summary>
		[IsRequired]
		[JsonProperty("items")]
		public List<Item> Items { get; set; }
	}
}
