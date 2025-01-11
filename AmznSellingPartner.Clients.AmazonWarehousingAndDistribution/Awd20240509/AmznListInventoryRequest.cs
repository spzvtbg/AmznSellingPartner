namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpGet("/awd/2024-05-09/inventory")]
	public class AmznListInventoryRequest : BaseHttpRequest
	{
		/// <summary>
		/// Filter by seller or merchant SKU for the item.
		/// </summary>
		[InQuery("sku")]
		public string Sku { get; set; } 

		/// <summary>
		/// Sort the response in `ASCENDING` or `DESCENDING` order.
		/// </summary>
		[InQuery("sortOrder")]
		public SortOrder SortOrder { get; set; } 

		/// <summary>
		/// Set to `SHOW` to return summaries with additional inventory details. Defaults to `HIDE,` which
		/// returns only inventory summary totals.
		/// </summary>
		[InQuery("details")]
		public Details Details { get; set; } 

		/// <summary>
		/// A token that is used to retrieve the next page of results. The response includes `nextToken`
		/// when the number of results exceeds the specified `maxResults` value. To get the next page of
		/// results, call the operation with this token and include the same arguments as the call that
		/// produced the token. To get a complete list, call this operation until `nextToken` is null.
		/// Note that this operation can return empty pages.
		/// </summary>
		[InQuery("nextToken")]
		public string NextToken { get; set; } 

		/// <summary>
		/// Maximum number of results to return.
		/// </summary>
		[InQuery("maxResults")]
		[Minimum(1)]
		[Maximum(200)]
		public int MaxResults { get; set; } = 25;
	}
}
