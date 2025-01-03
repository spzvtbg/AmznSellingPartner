namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Selling partner listings items and search related metadata.
	/// </summary>
	public class ItemSearchResults : BaseClass
	{
		/// <summary>
		/// The total number of selling partner listings items found for the search criteria (only results up to
		/// the page count limit will be returned per request regardless of the number found).  Note: The maximum
		/// number of items (SKUs) that can be returned and paged through is 1000.
		/// </summary>
		[IsRequired]
		[JsonProperty("numberOfResults")]
		public int NumberOfResults { get; set; }

		/// <summary>
		/// If available, the `nextToken` and/or `previousToken` values required to return paginated results.
		/// </summary>
		[JsonProperty("pagination")]
		public Pagination Pagination { get; set; }

		/// <summary>
		/// A list of listings items.
		/// </summary>
		[IsRequired]
		[JsonProperty("items")]
		public List<Item> Items { get; set; }
	}
}
