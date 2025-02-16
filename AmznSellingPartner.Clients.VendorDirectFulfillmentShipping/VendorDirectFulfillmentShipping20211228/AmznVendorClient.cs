namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
    using System;
    using System.Threading.Tasks;

    public class AmznVendorClient(Uri baseAddress) : BaseHttpClient(baseAddress)
    {
        /// <summary>
        /// Returns a list of shipping labels created during the time frame that you specify. Use the `createdAfter`
        /// and `createdBefore` parameters to define the time frame. You must use both of these parameters.
        /// The date range to search must not be more than seven days.  **Usage Plan:**  | Rate (requests
        /// per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header
        /// returns the usage plan rate limits that were applied to the requested operation, when available.
        /// The preceding table indicates the default rate and burst values for this operation. Selling
        /// partners whose business demands require higher throughput may have higher rate and burst values
        /// then those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling
        /// Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits).
        /// </summary>
        public async Task<AmznGetShippingLabelsResponse> GetShippingLabelsAsync(AmznGetShippingLabelsRequest request)
            => await SendAsync<AmznGetShippingLabelsResponse>(request);

        /// <summary>
        /// Creates a shipping label for a purchase order and returns a `transactionId` for reference.
        /// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The preceding table indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may have higher rate and
        /// burst values then those shown here. For more information, refer to [Usage Plans and Rate Limits
        /// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
        /// rate-limits).
        /// </summary>
        public async Task<AmznSubmitShippingLabelRequestResponse> SubmitShippingLabelRequestAsync(AmznSubmitShippingLabelRequestRequest request)
            => await SendAsync<AmznSubmitShippingLabelRequestResponse>(request);

        /// <summary>
        /// Returns a shipping label for the `purchaseOrderNumber` that you specify.  **Usage Plan:**
        /// | Rate (requests per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The preceding table indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may have higher rate and
        /// burst values then those shown here. For more information, refer to [Usage Plans and Rate Limits
        /// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
        /// rate-limits).
        /// </summary>
        public async Task<AmznGetShippingLabelResponse> GetShippingLabelAsync(AmznGetShippingLabelRequest request)
            => await SendAsync<AmznGetShippingLabelResponse>(request);

        /// <summary>
        /// Creates shipping labels for a purchase order and returns the labels.  **Usage Plan:**  | Rate
        /// (requests per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response
        /// header returns the usage plan rate limits that were applied to the requested operation, when
        /// available. The preceding table indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may have higher rate and
        /// burst values then those shown here. For more information, refer to [Usage Plans and Rate Limits
        /// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
        /// rate-limits).
        /// </summary>
        public async Task<AmznCreateShippingLabelsResponse> CreateShippingLabelsAsync(AmznCreateShippingLabelsRequest request)
            => await SendAsync<AmznCreateShippingLabelsResponse>(request);

        /// <summary>
        /// Submits one or more shipment confirmations for vendor orders.  **Usage Plan:**  | Rate (requests
        /// per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header
        /// returns the usage plan rate limits that were applied to the requested operation, when available.
        /// The preceding table indicates the default rate and burst values for this operation. Selling
        /// partners whose business demands require higher throughput may have higher rate and burst values
        /// then those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling
        /// Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits).
        /// </summary>
        public async Task<AmznSubmitShipmentConfirmationsResponse> SubmitShipmentConfirmationsAsync(AmznSubmitShipmentConfirmationsRequest request)
            => await SendAsync<AmznSubmitShipmentConfirmationsResponse>(request);

        /// <summary>
        /// This operation is only to be used by Vendor-Own-Carrier (VOC) vendors. Calling this API submits
        /// a shipment status update for the package that a vendor has shipped. It will provide the Amazon
        /// customer visibility on their order, when the package is outside of Amazon Network visibility.
        /// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The preceding table indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may have higher rate and
        /// burst values then those shown here. For more information, refer to [Usage Plans and Rate Limits
        /// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
        /// rate-limits).
        /// </summary>
        public async Task<AmznSubmitShipmentStatusUpdatesResponse> SubmitShipmentStatusUpdatesAsync(AmznSubmitShipmentStatusUpdatesRequest request)
            => await SendAsync<AmznSubmitShipmentStatusUpdatesResponse>(request);

        /// <summary>
        /// Returns a list of customer invoices created during a time frame that you specify. You define
        /// the time frame using the createdAfter and createdBefore parameters. You must use both of these
        /// parameters. The date range to search must be no more than 7 days.  **Usage Plan:**  | Rate
        /// (requests per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response
        /// header returns the usage plan rate limits that were applied to the requested operation, when
        /// available. The preceding table indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may have higher rate and
        /// burst values then those shown here. For more information, refer to [Usage Plans and Rate Limits
        /// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
        /// rate-limits).
        /// </summary>
        public async Task<AmznGetCustomerInvoicesResponse> GetCustomerInvoicesAsync(AmznGetCustomerInvoicesRequest request)
            => await SendAsync<AmznGetCustomerInvoicesResponse>(request);

        /// <summary>
        /// Returns a customer invoice based on the purchaseOrderNumber that you specify.  **Usage Plan:**
        /// | Rate (requests per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The preceding table indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may have higher rate and
        /// burst values then those shown here. For more information, refer to [Usage Plans and Rate Limits
        /// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
        /// rate-limits).
        /// </summary>
        public async Task<AmznGetCustomerInvoiceResponse> GetCustomerInvoiceAsync(AmznGetCustomerInvoiceRequest request)
            => await SendAsync<AmznGetCustomerInvoiceResponse>(request);

        /// <summary>
        /// Returns a list of packing slips for the purchase orders that match the criteria specified.
        /// Date range to search must not be more than 7 days.  **Usage Plan:**  | Rate (requests per second)
        /// | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit` response header returns
        /// the usage plan rate limits that were applied to the requested operation, when available. The
        /// preceding table indicates the default rate and burst values for this operation. Selling partners
        /// whose business demands require higher throughput may have higher rate and burst values then
        /// those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling
        /// Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits).
        /// </summary>
        public async Task<AmznGetPackingSlipsResponse> GetPackingSlipsAsync(AmznGetPackingSlipsRequest request)
            => await SendAsync<AmznGetPackingSlipsResponse>(request);

        /// <summary>
        /// Returns a packing slip based on the purchaseOrderNumber that you specify.  **Usage Plan:**
        /// | Rate (requests per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The preceding table indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may have higher rate and
        /// burst values then those shown here. For more information, refer to [Usage Plans and Rate Limits
        /// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
        /// rate-limits).
        /// </summary>
        public async Task<AmznGetPackingSlipResponse> GetPackingSlipAsync(AmznGetPackingSlipRequest request)
            => await SendAsync<AmznGetPackingSlipResponse>(request);

        /// <summary>
        /// Creates a container (pallet) label for the associated shipment package.  **Usage Plan:**  |
        /// Rate (requests per second) | Burst | | ---- | ---- | | 10 | 10 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The preceding table contains the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may have higher rate and
        /// burst values than those shown here. For more information, refer to [Usage Plans and Rate Limits
        /// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-
        /// rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznCreateContainerLabelResponse> CreateContainerLabelAsync(AmznCreateContainerLabelRequest request)
            => await SendAsync<AmznCreateContainerLabelResponse>(request);
    }
}
