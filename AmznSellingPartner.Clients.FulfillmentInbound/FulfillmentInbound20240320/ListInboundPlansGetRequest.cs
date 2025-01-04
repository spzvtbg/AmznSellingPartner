namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpGet("/inbound/fba/2024-03-20/inboundPlans")]
	public class ListInboundPlansGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The number of inbound plans to return in the response matching the given query.
		/// </summary>
		[InQuery("pageSize")]
		[Minimum(1)]
		[Maximum(30)]
		public int PageSize { get; set; }

		/// <summary>
		/// A token to fetch a certain page when there are multiple pages worth of results. The value of this token
		/// is fetched from the `pagination` returned in the API response. In the absence of the token value from
		/// the query parameter the API returns the first page of the result.
		/// </summary>
		[InQuery("paginationToken")]
		[MinLength(0)]
		[MaxLength(1024)]
		public string PaginationToken { get; set; }

		/// <summary>
		/// The status of an inbound plan.
		/// </summary>
		[InQuery("status")]
		public Status Status { get; set; }

		/// <summary>
		/// Sort by field.
		/// </summary>
		[InQuery("sortBy")]
		public SortBy SortBy { get; set; }

		/// <summary>
		/// The sort order.
		/// </summary>
		[InQuery("sortOrder")]
		public SortOrder SortOrder { get; set; }
	}
}
