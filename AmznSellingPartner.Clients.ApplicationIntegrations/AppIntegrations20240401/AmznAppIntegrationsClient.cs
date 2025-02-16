namespace AmznSellingPartner.Clients.ApplicationIntegrations.AppIntegrations20240401
{
    using System;
    using System.Threading.Tasks;

    public class AmznAppIntegrationsClient(Uri baseAddress) : BaseHttpClient(baseAddress)
    {
        /// <summary>
        /// Create a notification for sellers in Seller Central.  **Usage Plan:**  | Rate (requests per
        /// second) | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header returns
        /// the usage plan rate limits that were applied to the requested operation, when available. The
        /// preceding table indicates the default rate and burst values for this operation. Sellers whose
        /// business demands require higher throughput may have higher rate and burst values than those
        /// shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner
        /// API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-a
        /// pi).
        /// </summary>
        public async Task<AmznCreateNotificationResponse> CreateNotificationAsync(AmznCreateNotificationRequest request)
            => await SendAsync<AmznCreateNotificationResponse>(request);

        /// <summary>
        /// Remove your application's notifications from the Appstore notifications dashboard.  **Usage
        /// Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The preceding table indicates the default rate and burst values for this operation.
        /// Sellers whose business demands require higher throughput may have higher rate and burst values
        /// than those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling
        /// Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-
        /// the-sp-api).
        /// </summary>
        public async Task<AmznDeleteNotificationsResponse> DeleteNotificationsAsync(AmznDeleteNotificationsRequest request)
            => await SendAsync<AmznDeleteNotificationsResponse>(request);

        /// <summary>
        /// Records the seller's response to a notification.  **Usage Plan:**  | Rate (requests per second)
        /// | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header returns the
        /// usage plan rate limits that were applied to the requested operation, when available. The preceding
        /// table indicates the default rate and burst values for this operation. Sellers whose business
        /// demands require higher throughput may have higher rate and burst values than those shown here.
        /// For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](ht
        /// tps://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznRecordActionFeedbackResponse> RecordActionFeedbackAsync(AmznRecordActionFeedbackRequest request)
            => await SendAsync<AmznRecordActionFeedbackResponse>(request);
    }
}
