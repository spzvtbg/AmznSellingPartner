namespace AmznSellingPartner.Clients.Reports.Reports20210630
{
	using System;
	using System.Threading.Tasks;

	public class ReportsClient(Uri baseAddress) : BaseHttpClient(baseAddress)
	{
		/// <summary>
		/// Returns report details for the reports that match the filters that you specify.  **Usage Plan:**  | Rate
		/// (requests per second) | Burst | | ---- | ---- | | 0.0222 | 10 |  The `x-amzn-RateLimit-Limit` response
		/// header returns the usage plan rate limits that were applied to the requested operation, when available.
		/// The table above indicates the default rate and burst values for this operation. Selling partners whose
		/// business demands require higher throughput may see higher rate and burst values than those shown here.
		/// For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://deve
		/// loper-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetReportsGetResponse> GetReportsAsync(GetReportsGetRequest request)
		    => await this.SendAsync<GetReportsGetResponse>(request);

		/// <summary>
		/// Creates a report.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 0.0167 |
		/// 15 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied
		/// to the requested operation, when available. The table above indicates the default rate and burst values
		/// for this operation. Selling partners whose business demands require higher throughput may see higher
		/// rate and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
		/// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limit
		/// s-in-the-sp-api).
		/// </summary>
		public async Task<CreateReportPostResponse> CreateReportAsync(CreateReportPostRequest request)
		    => await this.SendAsync<CreateReportPostResponse>(request);

		/// <summary>
		/// Cancels the report that you specify. Only reports with `processingStatus=IN_QUEUE` can be cancelled.
		/// Cancelled reports are returned in subsequent calls to the `getReport` and `getReports` operations.  **Usage
		/// Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 0.0222 | 10 |  The `x-amzn-RateLimit-Limit`
		/// response header returns the usage plan rate limits that were applied to the requested operation, when
		/// available. The table above indicates the default rate and burst values for this operation. Selling partners
		/// whose business demands require higher throughput may see higher rate and burst values than those shown
		/// here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https:
		/// //developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CancelReportDeleteResponse> CancelReportAsync(CancelReportDeleteRequest request)
		    => await this.SendAsync<CancelReportDeleteResponse>(request);

		/// <summary>
		/// Returns report details (including the `reportDocumentId`, if available) for the report that you specify.
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 15 |  The `x-amzn-RateLimit-Limit`
		/// response header returns the usage plan rate limits that were applied to the requested operation, when
		/// available. The table above indicates the default rate and burst values for this operation. Selling partners
		/// whose business demands require higher throughput may see higher rate and burst values than those shown
		/// here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https:
		/// //developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetReportGetResponse> GetReportAsync(GetReportGetRequest request)
		    => await this.SendAsync<GetReportGetResponse>(request);

		/// <summary>
		/// Returns report schedule details that match the filters that you specify.  **Usage Plan:**  | Rate (requests
		/// per second) | Burst | | ---- | ---- | | 0.0222 | 10 |  The `x-amzn-RateLimit-Limit` response header returns
		/// the usage plan rate limits that were applied to the requested operation, when available. The table above
		/// indicates the default rate and burst values for this operation. Selling partners whose business demands
		/// require higher throughput may see higher rate and burst values than those shown here. For more information,
		/// refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/
		/// sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetReportSchedulesGetResponse> GetReportSchedulesAsync(GetReportSchedulesGetRequest request)
		    => await this.SendAsync<GetReportSchedulesGetResponse>(request);

		/// <summary>
		/// Creates a report schedule. If a report schedule with the same report type and marketplace IDs already
		/// exists, it will be cancelled and replaced with this one.  **Usage Plan:**  | Rate (requests per second)
		/// | Burst | | ---- | ---- | | 0.0222 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage
		/// plan rate limits that were applied to the requested operation, when available. The table above indicates
		/// the default rate and burst values for this operation. Selling partners whose business demands require
		/// higher throughput may see higher rate and burst values than those shown here. For more information, refer
		/// to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api
		/// /docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CreateReportSchedulePostResponse> CreateReportScheduleAsync(CreateReportSchedulePostRequest request)
		    => await this.SendAsync<CreateReportSchedulePostResponse>(request);

		/// <summary>
		/// Cancels the report schedule that you specify.  **Usage Plan:**  | Rate (requests per second) | Burst
		/// | | ---- | ---- | | 0.0222 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan
		/// rate limits that were applied to the requested operation, when available. The table above indicates the
		/// default rate and burst values for this operation. Selling partners whose business demands require higher
		/// throughput may see higher rate and burst values than those shown here. For more information, refer to
		/// [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/do
		/// cs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CancelReportScheduleDeleteResponse> CancelReportScheduleAsync(CancelReportScheduleDeleteRequest request)
		    => await this.SendAsync<CancelReportScheduleDeleteResponse>(request);

		/// <summary>
		/// Returns report schedule details for the report schedule that you specify.  **Usage Plan:**  | Rate (requests
		/// per second) | Burst | | ---- | ---- | | 0.0222 | 10 |  The `x-amzn-RateLimit-Limit` response header returns
		/// the usage plan rate limits that were applied to the requested operation, when available. The table above
		/// indicates the default rate and burst values for this operation. Selling partners whose business demands
		/// require higher throughput may see higher rate and burst values than those shown here. For more information,
		/// refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/
		/// sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetReportScheduleGetResponse> GetReportScheduleAsync(GetReportScheduleGetRequest request)
		    => await this.SendAsync<GetReportScheduleGetResponse>(request);

		/// <summary>
		/// Returns the information required for retrieving a report document's contents.  **Usage Plan:**  | Rate
		/// (requests per second) | Burst | | ---- | ---- | | 0.0167 | 15 |  The `x-amzn-RateLimit-Limit` response
		/// header returns the usage plan rate limits that were applied to the requested operation, when available.
		/// The table above indicates the default rate and burst values for this operation. Selling partners whose
		/// business demands require higher throughput may see higher rate and burst values than those shown here.
		/// For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://deve
		/// loper-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetReportDocumentGetResponse> GetReportDocumentAsync(GetReportDocumentGetRequest request)
		    => await this.SendAsync<GetReportDocumentGetResponse>(request);
	}
}
