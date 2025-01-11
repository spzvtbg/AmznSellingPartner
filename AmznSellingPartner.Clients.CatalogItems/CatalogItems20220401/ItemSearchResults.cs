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
		/// For `identifiers`-based searches, the total number of Amazon catalog items found. For `keywords`-based
		/// searches, the estimated total number of Amazon catalog items matched by the search query (only
		/// results up to the page count limit will be returned per request regardless of the number found).
		/// Note: The maximum number of items (ASINs) that can be returned and paged through is 1000.
		/// </summary>
		[JsonProperty("numberOfResults")]
		[IsRequired]
		public int NumberOfResults { get; set; } 

		/// <summary>
		/// If available, the `nextToken` and/or `previousToken` values required to return paginated r
		/// esults.
		/// </summary>
		[JsonProperty("pagination")]
		[IsRequired]
		public Pagination Pagination { get; set; } 

		/// <summary>
		/// Search refinements for `keywords`-based searches.
		/// </summary>
		[JsonProperty("refinements")]
		[IsRequired]
		public Refinements Refinements { get; set; } 

		/// <summary>
		/// A list of items from the Amazon catalog.
		/// </summary>
		[JsonProperty("items")]
		[IsRequired]
		public List<Item> Items { get; set; } 
	}
}
