namespace AmznSellingPartner.Clients.Reports.Reports20210630
{
    using System;
    using System.Threading.Tasks;

    public class AmznReportsClient(Uri baseAddress) : BaseHttpClient(baseAddress)
    {
        /// <summary>
        /// Returns report details for the reports that match the filters that you specify.  **Usage Plan:**
        /// | Rate (requests per second) | Burst | | ---- | ---- | | 0.0222 | 10 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The table above indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may see higher rate and burst
        /// values than those shown here. For more information, refer to [Usage Plans and Rate Limits in
        /// the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rat
        /// e-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznGetReportsResponse> GetReportsAsync(AmznGetReportsRequest request)
            => await SendAsync<AmznGetReportsResponse>(request);

        /// <summary>
        /// Creates a report.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- |
        /// | 0.0167 | 15 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits
        /// that were applied to the requested operation, when available. The table above indicates the
        /// default rate and burst values for this operation. Selling partners whose business demands require
        /// higher throughput may see higher rate and burst values than those shown here. For more information,
        /// refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.a
        /// mazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznCreateReportResponse> CreateReportAsync(AmznCreateReportRequest request)
            => await SendAsync<AmznCreateReportResponse>(request);

        /// <summary>
        /// Cancels the report that you specify. Only reports with `processingStatus=IN_QUEUE` can be cancelled.
        /// Cancelled reports are returned in subsequent calls to the `getReport` and `getReports` operations.
        /// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 0.0222 | 10 |  The
        /// `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied
        /// to the requested operation, when available. The table above indicates the default rate and
        /// burst values for this operation. Selling partners whose business demands require higher throughput
        /// may see higher rate and burst values than those shown here. For more information, refer to
        /// [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com
        /// /sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznCancelReportResponse> CancelReportAsync(AmznCancelReportRequest request)
            => await SendAsync<AmznCancelReportResponse>(request);

        /// <summary>
        /// Returns report details (including the `reportDocumentId`, if available) for the report that
        /// you specify.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 |
        /// 15 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that
        /// were applied to the requested operation, when available. The table above indicates the default
        /// rate and burst values for this operation. Selling partners whose business demands require higher
        /// throughput may see higher rate and burst values than those shown here. For more information,
        /// refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.a
        /// mazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznGetReportResponse> GetReportAsync(AmznGetReportRequest request)
            => await SendAsync<AmznGetReportResponse>(request);

        /// <summary>
        /// Returns report schedule details that match the filters that you specify.  **Usage Plan:**
        /// | Rate (requests per second) | Burst | | ---- | ---- | | 0.0222 | 10 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The table above indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may see higher rate and burst
        /// values than those shown here. For more information, refer to [Usage Plans and Rate Limits in
        /// the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rat
        /// e-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznGetReportSchedulesResponse> GetReportSchedulesAsync(AmznGetReportSchedulesRequest request)
            => await SendAsync<AmznGetReportSchedulesResponse>(request);

        /// <summary>
        /// Creates a report schedule. If a report schedule with the same report type and marketplace IDs
        /// already exists, it will be cancelled and replaced with this one.  **Usage Plan:**  | Rate (requests
        /// per second) | Burst | | ---- | ---- | | 0.0222 | 10 |  The `x-amzn-RateLimit-Limit` response
        /// header returns the usage plan rate limits that were applied to the requested operation, when
        /// available. The table above indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may see higher rate and burst
        /// values than those shown here. For more information, refer to [Usage Plans and Rate Limits in
        /// the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rat
        /// e-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznCreateReportScheduleResponse> CreateReportScheduleAsync(AmznCreateReportScheduleRequest request)
            => await SendAsync<AmznCreateReportScheduleResponse>(request);

        /// <summary>
        /// Cancels the report schedule that you specify.  **Usage Plan:**  | Rate (requests per second)
        /// | Burst | | ---- | ---- | | 0.0222 | 10 |  The `x-amzn-RateLimit-Limit` response header returns
        /// the usage plan rate limits that were applied to the requested operation, when available. The
        /// table above indicates the default rate and burst values for this operation. Selling partners
        /// whose business demands require higher throughput may see higher rate and burst values than
        /// those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling
        /// Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-
        /// the-sp-api).
        /// </summary>
        public async Task<AmznCancelReportScheduleResponse> CancelReportScheduleAsync(AmznCancelReportScheduleRequest request)
            => await SendAsync<AmznCancelReportScheduleResponse>(request);

        /// <summary>
        /// Returns report schedule details for the report schedule that you specify.  **Usage Plan:**
        /// | Rate (requests per second) | Burst | | ---- | ---- | | 0.0222 | 10 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The table above indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may see higher rate and burst
        /// values than those shown here. For more information, refer to [Usage Plans and Rate Limits in
        /// the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rat
        /// e-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznGetReportScheduleResponse> GetReportScheduleAsync(AmznGetReportScheduleRequest request)
            => await SendAsync<AmznGetReportScheduleResponse>(request);

        /// <summary>
        /// Returns the information required for retrieving a report document's contents.  **Usage Plan:**
        /// | Rate (requests per second) | Burst | | ---- | ---- | | 0.0167 | 15 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The table above indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may see higher rate and burst
        /// values than those shown here. For more information, refer to [Usage Plans and Rate Limits in
        /// the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rat
        /// e-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznGetReportDocumentResponse> GetReportDocumentAsync(AmznGetReportDocumentRequest request)
            => await SendAsync<AmznGetReportDocumentResponse>(request);
    }
}
