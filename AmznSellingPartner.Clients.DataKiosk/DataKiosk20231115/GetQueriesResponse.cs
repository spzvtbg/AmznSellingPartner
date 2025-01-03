namespace AmznSellingPartner.Clients.DataKiosk.DataKiosk20231115
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The response for the `getQueries` operation.
	/// </summary>
	public class GetQueriesResponse : BaseClass
	{
		/// <summary>
		/// The Data Kiosk queries.
		/// </summary>
		[IsRequired]
		[JsonProperty("queries")]
		public QueryList Queries { get; set; }

		/// <summary>
		/// When a request has results that are not included in this response, pagination occurs. This means the results a
		/// e divided into pages. To retrieve the next page, you must pass the `nextToken` as the `paginationToken` query
		/// arameter in the subsequent `getQueries` request. All other parameters must be provided with the same values th
		/// t were provided with the request that generated this token, with the exception of `pageSize` which can be modi
		/// ied between calls to `getQueries`. When there are no more pages to fetch, the `nextToken` field will be absent
		/// 
		/// </summary>
		[JsonProperty("pagination")]
		public Pagination Pagination { get; set; }
	}
}
