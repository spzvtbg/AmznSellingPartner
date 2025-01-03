namespace AmznSellingPartner.Clients.DataKiosk.DataKiosk20231115
{
	using System;
	using System.Threading.Tasks;

	public class QueriesClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Returns details for the Data Kiosk queries that match the specified filters. See the `createQuery` operation f
		/// r details about query retention.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 0.
		/// 222 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied
		/// o the requested operation, when available. The table above indicates the default rate and burst values for thi
		/// operation. Selling partners whose business demands require higher throughput may see higher rate and burst va
		/// ues than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner
		/// PI](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetQueriesGetResponse> GetQueriesAsync(GetQueriesGetRequest request)
		    => await this.SendAsync<GetQueriesGetResponse>(request);

		/// <summary>
		/// Creates a Data Kiosk query request.  **Note:** The retention of a query varies based on the fields requested.
		/// ach field within a schema is annotated with a `@resultRetention` directive that defines how long a query conta
		/// ning that field will be retained. When a query contains multiple fields with different retentions, the shortes
		/// (minimum) retention is applied. The retention of a query's resulting documents always matches the retention o
		/// the query.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 0.0167 | 15 |  The `x-a
		/// zn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested oper
		/// tion, when available. The table above indicates the default rate and burst values for this operation. Selling
		/// artners whose business demands require higher throughput may see higher rate and burst values than those shown
		/// here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://develope
		/// -docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CreateQueryPostResponse> CreateQueryAsync(CreateQueryPostRequest request)
		    => await this.SendAsync<CreateQueryPostResponse>(request);

		/// <summary>
		/// Cancels the query specified by the `queryId` parameter. Only queries with a non-terminal `processingStatus` (`
		/// N_QUEUE`, `IN_PROGRESS`) can be cancelled. Cancelling a query that already has a `processingStatus` of `CANCEL
		/// ED` will no-op. Cancelled queries are returned in subsequent calls to the `getQuery` and `getQueries` operatio
		/// s.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 0.0222 | 10 |  The `x-amzn-RateL
		/// mit-Limit` response header returns the usage plan rate limits that were applied to the requested operation, wh
		/// n available. The table above indicates the default rate and burst values for this operation. Selling partners
		/// hose business demands require higher throughput may see higher rate and burst values than those shown here. Fo
		/// more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.am
		/// zon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CancelQueryDeleteResponse> CancelQueryAsync(CancelQueryDeleteRequest request)
		    => await this.SendAsync<CancelQueryDeleteResponse>(request);

		/// <summary>
		/// Returns query details for the query specified by the `queryId` parameter. See the `createQuery` operation for
		/// etails about query retention.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2.0 |
		/// 15 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the
		/// requested operation, when available. The table above indicates the default rate and burst values for this oper
		/// tion. Selling partners whose business demands require higher throughput may see higher rate and burst values t
		/// an those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](h
		/// tps://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetQueryGetResponse> GetQueryAsync(GetQueryGetRequest request)
		    => await this.SendAsync<GetQueryGetResponse>(request);

		/// <summary>
		/// Returns the information required for retrieving a Data Kiosk document's contents. See the `createQuery` operat
		/// on for details about document retention.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---
		/// | | 0.0167 | 15 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were
		/// pplied to the requested operation, when available. The table above indicates the default rate and burst values
		/// for this operation. Selling partners whose business demands require higher throughput may see higher rate and
		/// urst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling
		/// artner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetDocumentGetResponse> GetDocumentAsync(GetDocumentGetRequest request)
		    => await this.SendAsync<GetDocumentGetResponse>(request);
	}
}
