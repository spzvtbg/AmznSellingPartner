namespace AmznSellingPartner.Clients.ShipmentInvoicing.ShipmentInvoicingV0
{
    using System;
    using System.Threading.Tasks;

    public class AmznFbaClient(Uri baseAddress) : BaseHttpClient(baseAddress)
    {
        /// <summary>
        /// Returns the shipment details required to issue an invoice for the specified shipment.  **Usage
        /// Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1.133 | 25 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The table above indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may see higher rate and burst
        /// values than those shown here. For more information, see [Usage Plans and Rate Limits in the
        /// Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznGetShipmentDetailsResponse> GetShipmentDetailsAsync(AmznGetShipmentDetailsRequest request)
            => await SendAsync<AmznGetShipmentDetailsResponse>(request);

        /// <summary>
        /// Submits a shipment invoice document for a given shipment.  **Usage Plan:**  | Rate (requests
        /// per second) | Burst | | ---- | ---- | | 1.133 | 25 |  The `x-amzn-RateLimit-Limit` response
        /// header returns the usage plan rate limits that were applied to the requested operation, when
        /// available. The table above indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may see higher rate and burst
        /// values than those shown here. For more information, see [Usage Plans and Rate Limits in the
        /// Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznSubmitInvoiceResponse> SubmitInvoiceAsync(AmznSubmitInvoiceRequest request)
            => await SendAsync<AmznSubmitInvoiceResponse>(request);

        /// <summary>
        /// Returns the invoice status for the shipment you specify.  **Usage Plan:**  | Rate (requests
        /// per second) | Burst | | ---- | ---- | | 1.133 | 25 |  The `x-amzn-RateLimit-Limit` response
        /// header returns the usage plan rate limits that were applied to the requested operation, when
        /// available. The table above indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may see higher rate and burst
        /// values than those shown here. For more information, see [Usage Plans and Rate Limits in the
        /// Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznGetInvoiceStatusResponse> GetInvoiceStatusAsync(AmznGetInvoiceStatusRequest request)
            => await SendAsync<AmznGetInvoiceStatusResponse>(request);
    }
}
