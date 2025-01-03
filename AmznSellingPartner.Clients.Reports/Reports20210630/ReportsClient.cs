namespace AmznSellingPartner.Clients.Reports.Reports20210630
{
	using System;
	using System.Threading.Tasks;

	public class ReportsClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Returns report details for the reports that match the filters that you specify.  **Usage Plan:**  | Rate (requ
		/// sts per second) | Burst | | ---- | ---- | | 0.0222 | 10 |  The `x-amzn-RateLimit-Limit` response header return
		/// the usage plan rate limits that were applied to the requested operation, when available. The table above indi
		/// ates the default rate and burst values for this operation. Selling partners whose business demands require hig
		/// er throughput may see higher rate and burst values than those shown here. For more information, refer to [Usag
		/// Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-a
		/// d-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetReportsGetResponse> GetReportsAsync(GetReportsGetRequest request)
		    => await this.SendAsync<GetReportsGetResponse>(request);

		/// <summary>
		/// Creates a report.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 0.0167 | 15 |  Th
		/// `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requeste
		/// operation, when available. The table above indicates the default rate and burst values for this operation. Se
		/// ling partners whose business demands require higher throughput may see higher rate and burst values than those
		/// shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://de
		/// eloper-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CreateReportPostResponse> CreateReportAsync(CreateReportPostRequest request)
		    => await this.SendAsync<CreateReportPostResponse>(request);

		/// <summary>
		/// Cancels the report that you specify. Only reports with `processingStatus=IN_QUEUE` can be cancelled. Cancelled
		/// reports are returned in subsequent calls to the `getReport` and `getReports` operations.  **Usage Plan:**  | R
		/// te (requests per second) | Burst | | ---- | ---- | | 0.0222 | 10 |  The `x-amzn-RateLimit-Limit` response head
		/// r returns the usage plan rate limits that were applied to the requested operation, when available. The table a
		/// ove indicates the default rate and burst values for this operation. Selling partners whose business demands re
		/// uire higher throughput may see higher rate and burst values than those shown here. For more information, refer
		/// to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usag
		/// -plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CancelReportDeleteResponse> CancelReportAsync(CancelReportDeleteRequest request)
		    => await this.SendAsync<CancelReportDeleteResponse>(request);

		/// <summary>
		/// Returns report details (including the `reportDocumentId`, if available) for the report that you specify.  **Us
		/// ge Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 15 |  The `x-amzn-RateLimit-Limit` re
		/// ponse header returns the usage plan rate limits that were applied to the requested operation, when available.
		/// he table above indicates the default rate and burst values for this operation. Selling partners whose business
		/// demands require higher throughput may see higher rate and burst values than those shown here. For more informa
		/// ion, refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-ap
		/// /docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetReportGetResponse> GetReportAsync(GetReportGetRequest request)
		    => await this.SendAsync<GetReportGetResponse>(request);

		/// <summary>
		/// Returns report schedule details that match the filters that you specify.  **Usage Plan:**  | Rate (requests pe
		/// second) | Burst | | ---- | ---- | | 0.0222 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the u
		/// age plan rate limits that were applied to the requested operation, when available. The table above indicates t
		/// e default rate and burst values for this operation. Selling partners whose business demands require higher thr
		/// ughput may see higher rate and burst values than those shown here. For more information, refer to [Usage Plans
		/// and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate
		/// limits-in-the-sp-api).
		/// </summary>
		public async Task<GetReportSchedulesGetResponse> GetReportSchedulesAsync(GetReportSchedulesGetRequest request)
		    => await this.SendAsync<GetReportSchedulesGetResponse>(request);

		/// <summary>
		/// Creates a report schedule. If a report schedule with the same report type and marketplace IDs already exists,
		/// t will be cancelled and replaced with this one.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---
		/// | ---- | | 0.0222 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits tha
		/// were applied to the requested operation, when available. The table above indicates the default rate and burst
		/// values for this operation. Selling partners whose business demands require higher throughput may see higher ra
		/// e and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the S
		/// lling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CreateReportSchedulePostResponse> CreateReportScheduleAsync(CreateReportSchedulePostRequest request)
		    => await this.SendAsync<CreateReportSchedulePostResponse>(request);

		/// <summary>
		/// Cancels the report schedule that you specify.  **Usage Plan:**  | Rate (requests per second) | Burst | | ----
		/// ---- | | 0.0222 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that
		/// ere applied to the requested operation, when available. The table above indicates the default rate and burst v
		/// lues for this operation. Selling partners whose business demands require higher throughput may see higher rate
		/// and burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Sel
		/// ing Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CancelReportScheduleDeleteResponse> CancelReportScheduleAsync(CancelReportScheduleDeleteRequest request)
		    => await this.SendAsync<CancelReportScheduleDeleteResponse>(request);

		/// <summary>
		/// Returns report schedule details for the report schedule that you specify.  **Usage Plan:**  | Rate (requests p
		/// r second) | Burst | | ---- | ---- | | 0.0222 | 10 |  The `x-amzn-RateLimit-Limit` response header returns the
		/// sage plan rate limits that were applied to the requested operation, when available. The table above indicates
		/// he default rate and burst values for this operation. Selling partners whose business demands require higher th
		/// oughput may see higher rate and burst values than those shown here. For more information, refer to [Usage Plan
		/// and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rat
		/// -limits-in-the-sp-api).
		/// </summary>
		public async Task<GetReportScheduleGetResponse> GetReportScheduleAsync(GetReportScheduleGetRequest request)
		    => await this.SendAsync<GetReportScheduleGetResponse>(request);

		/// <summary>
		/// Returns the information required for retrieving a report document's contents.  **Usage Plan:**  | Rate (reques
		/// s per second) | Burst | | ---- | ---- | | 0.0167 | 15 |  The `x-amzn-RateLimit-Limit` response header returns
		/// he usage plan rate limits that were applied to the requested operation, when available. The table above indica
		/// es the default rate and burst values for this operation. Selling partners whose business demands require highe
		/// throughput may see higher rate and burst values than those shown here. For more information, refer to [Usage
		/// lans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and
		/// rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetReportDocumentGetResponse> GetReportDocumentAsync(GetReportDocumentGetRequest request)
		    => await this.SendAsync<GetReportDocumentGetResponse>(request);
	}
}
