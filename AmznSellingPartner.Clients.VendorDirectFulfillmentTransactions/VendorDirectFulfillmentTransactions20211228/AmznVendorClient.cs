namespace AmznSellingPartner.Clients.VendorDirectFulfillmentTransactions.VendorDirectFulfillmentTransactions20211228
{
    using System;
    using System.Threading.Tasks;

    public class AmznVendorClient(Uri baseAddress) : BaseHttpClient(baseAddress)
    {
        /// <summary>
        /// Returns the status of the transaction indicated by the specified transactionId.  **Usage Plan:**
        /// | Rate (requests per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The table above indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may see higher rate and burst
        /// values then those shown here. For more information, see [Usage Plans and Rate Limits in the
        /// Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznGetTransactionStatusResponse> GetTransactionStatusAsync(AmznGetTransactionStatusRequest request)
            => await SendAsync<AmznGetTransactionStatusResponse>(request);
    }
}
