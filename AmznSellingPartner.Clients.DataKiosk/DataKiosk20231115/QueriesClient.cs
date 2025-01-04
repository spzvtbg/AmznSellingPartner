namespace AmznSellingPartner.Clients.DataKiosk.DataKiosk20231115
{
	using System;
	using System.Threading.Tasks;

	public class QueriesClient(Uri baseAddress) : BaseHttpClient(baseAddress)
	{
		/// <summary>
		/// Returns details for the Data Kiosk queries that match the specified filters. See the `createQuery` operation
		/// for details about query retention.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- |
		/// ---- | | 0.0222 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits
		/// that were applied to the requested operation, when available. The table above indicates the default rate
		/// and burst values for this operation. Selling partners whose business demands require higher throughput
		/// may see higher rate and burst values than those shown here. For more information, refer to [Usage Plans
		/// and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plan
		/// s-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetQueriesGetResponse> GetQueriesAsync(GetQueriesGetRequest request)
		    => await SendAsync<GetQueriesGetResponse>(request);

		/// <summary>
		/// Creates a Data Kiosk query request.  **Note:** The retention of a query varies based on the fields requested.
		/// Each field within a schema is annotated with a `@resultRetention` directive that defines how long a query
		/// containing that field will be retained. When a query contains multiple fields with different retentions,
		/// the shortest (minimum) retention is applied. The retention of a query's resulting documents always matches
		/// the retention of the query.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- |
		/// | 0.0167 | 15 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that
		/// were applied to the requested operation, when available. The table above indicates the default rate and
		/// burst values for this operation. Selling partners whose business demands require higher throughput may
		/// see higher rate and burst values than those shown here. For more information, refer to [Usage Plans and
		/// Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-an
		/// d-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CreateQueryPostResponse> CreateQueryAsync(CreateQueryPostRequest request)
		    => await SendAsync<CreateQueryPostResponse>(request);

		/// <summary>
		/// Cancels the query specified by the `queryId` parameter. Only queries with a non-terminal `processingStatus`
		/// (`IN_QUEUE`, `IN_PROGRESS`) can be cancelled. Cancelling a query that already has a `processingStatus`
		/// of `CANCELLED` will no-op. Cancelled queries are returned in subsequent calls to the `getQuery` and `getQueries`
		/// operations.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 0.0222 | 10 |
		/// The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to
		/// the requested operation, when available. The table above indicates the default rate and burst values
		/// for this operation. Selling partners whose business demands require higher throughput may see higher
		/// rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
		/// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limit
		/// s-in-the-sp-api).
		/// </summary>
		public async Task<CancelQueryDeleteResponse> CancelQueryAsync(CancelQueryDeleteRequest request)
		    => await SendAsync<CancelQueryDeleteResponse>(request);

		/// <summary>
		/// Returns query details for the query specified by the `queryId` parameter. See the `createQuery` operation
		/// for details about query retention.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- |
		/// ---- | | 2.0 | 15 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits
		/// that were applied to the requested operation, when available. The table above indicates the default rate
		/// and burst values for this operation. Selling partners whose business demands require higher throughput
		/// may see higher rate and burst values than those shown here. For more information, refer to [Usage Plans
		/// and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plan
		/// s-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetQueryGetResponse> GetQueryAsync(GetQueryGetRequest request)
		    => await SendAsync<GetQueryGetResponse>(request);

		/// <summary>
		/// Returns the information required for retrieving a Data Kiosk document's contents. See the `createQuery`
		/// operation for details about document retention.  **Usage Plan:**  | Rate (requests per second) | Burst
		/// | | ---- | ---- | | 0.0167 | 15 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan
		/// rate limits that were applied to the requested operation, when available. The table above indicates the
		/// default rate and burst values for this operation. Selling partners whose business demands require higher
		/// throughput may see higher rate and burst values than those shown here. For more information, refer to
		/// [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/do
		/// cs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetDocumentGetResponse> GetDocumentAsync(GetDocumentGetRequest request)
		    => await SendAsync<GetDocumentGetResponse>(request);
	}
}
