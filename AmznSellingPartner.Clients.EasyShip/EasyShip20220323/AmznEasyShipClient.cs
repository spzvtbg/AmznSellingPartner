namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
    using System;
    using System.Threading.Tasks;

    public class AmznEasyShipClient(Uri baseAddress) : BaseHttpClient(baseAddress)
    {
        /// <summary>
        /// Returns time slots available for Easy Ship orders to be scheduled based on the package weight
        /// and dimensions that the seller specifies.  This operation is available for scheduled and unscheduled
        /// orders based on marketplace support. See **Get Time Slots** in the [Marketplace Support Table](doc:easyship-api-v2022-03-23-use-case-guide#marketplace-support-table).
        /// This operation can return time slots that have either pickup or drop-off handover methods -
        /// see **Supported Handover Methods** in the [Marketplace Support Table](doc:easyship-api-v2022-03-23-use-case-guide#marketplace-support-table).
        /// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The table above indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may see higher rate and burst
        /// values than those shown here. For more information, see [Usage Plans and Rate Limits in the
        /// Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznListHandoverSlotsResponse> ListHandoverSlotsAsync(AmznListHandoverSlotsRequest request)
            => await SendAsync<AmznListHandoverSlotsResponse>(request);

        /// <summary>
        /// Returns information about a package, including dimensions, weight, time slot information for
        /// handover, invoice and item information, and status.  **Usage Plan:**  | Rate (requests per
        /// second) | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header returns
        /// the usage plan rate limits that were applied to the requested operation, when available. The
        /// table above indicates the default rate and burst values for this operation. Selling partners
        /// whose business demands require higher throughput may see higher rate and burst values than
        /// those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner
        /// API](doc:usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznGetScheduledPackageResponse> GetScheduledPackageAsync(AmznGetScheduledPackageRequest request)
            => await SendAsync<AmznGetScheduledPackageResponse>(request);

        /// <summary>
        /// Updates the time slot for handing over the package indicated by the specified `scheduledPackageId`.
        /// You can get the new `slotId` value for the time slot by calling the `listHandoverSlots` operation
        /// before making another `patch` call.  See the **Update Package** column in the [Marketplace
        /// Support Table](doc:easyship-api-v2022-03-23-use-case-guide#marketplace-support-table) to see
        /// which marketplaces this operation is supported in.  **Usage Plan:**  | Rate (requests per second)
        /// | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header returns the
        /// usage plan rate limits that were applied to the requested operation, when available. The table
        /// above indicates the default rate and burst values for this operation. Selling partners whose
        /// business demands require higher throughput may see higher rate and burst values than those
        /// shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner
        /// API](doc:usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznUpdateScheduledPackagesResponse> UpdateScheduledPackagesAsync(AmznUpdateScheduledPackagesRequest request)
            => await SendAsync<AmznUpdateScheduledPackagesResponse>(request);

        /// <summary>
        /// Schedules an Easy Ship order and returns the scheduled package information.  This operation
        /// does the following:  *  Specifies the time slot and handover method for the order to be scheduled
        /// for delivery.  * Updates the Easy Ship order status.  * Generates a shipping label and an invoice.
        /// Calling `createScheduledPackage` also generates a warranty document if you specify a `SerialNumber`
        /// value. To get these documents, see [How to get invoice, shipping label, and warranty documents](doc:easyship-api-v2022-03-23-use-case-guide).
        /// * Shows the status of Easy Ship orders when you call the `getOrders` operation of the Selling
        /// Partner API for Orders and examine the `EasyShipShipmentStatus` property in the response body.
        /// See the **Shipping Label**, **Invoice**, and **Warranty** columns in the [Marketplace Support
        /// Table](doc:easyship-api-v2022-03-23-use-case-guide#marketplace-support-table) to see which
        /// documents are supported in each marketplace.  **Usage Plan:**  | Rate (requests per second)
        /// | Burst | | ---- | ---- | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header returns the
        /// usage plan rate limits that were applied to the requested operation, when available. The table
        /// above indicates the default rate and burst values for this operation. Selling partners whose
        /// business demands require higher throughput may see higher rate and burst values than those
        /// shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner
        /// API](doc:usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznCreateScheduledPackageResponse> CreateScheduledPackageAsync(AmznCreateScheduledPackageRequest request)
            => await SendAsync<AmznCreateScheduledPackageResponse>(request);

        /// <summary>
        /// This operation automatically schedules a time slot for all specified `amazonOrderId` values
        /// and generates the associated shipping labels and compliance documents based on the marketplace.
        /// For more information, refer to the [marketplace support table](https://developer-docs.amazon.com/sp-api/docs/easyship-api-v2022-03-23-use-case-guide#marketplace-support-table).
        /// You can optionally assign a `packageDetails` object to input a preferred time slot for each
        /// order in your request. In such cases, Amazon schedules the respective packages using the specified
        /// optional settings. If you don't specify a time slot, Amazon assigns the earliest available
        /// time slot.   You can choose PDF or ZPL for your shipping label's file format and Amazon creates
        /// the label accordingly.  This operation returns an array that contains the scheduled packages,
        /// and a temporary URL that you can use to access a ZIP file. The ZIP file includes the generated
        /// shipping labels and any other documents that are required for your marketplace. If an order
        /// can't be scheduled, Amazon adds the `rejectedOrders` list in the response. The response contains
        /// an entry for each order that could not be processed. Each entry contains an error message that
        /// describes the reason for the failure.  The following table contains the supported request and
        /// burst maximum rates:  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ----
        /// | | 1 | 5 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits
        /// that are applied to the requested operation, when available. The preceding table contains the
        /// default rate and burst values for this operation. Selling partners whose business demands require
        /// higher throughput might have higher rate and burst values than those shown here. For more information,
        /// refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.a
        /// mazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznCreateScheduledPackageBulkResponse> CreateScheduledPackageBulkAsync(AmznCreateScheduledPackageBulkRequest request)
            => await SendAsync<AmznCreateScheduledPackageBulkResponse>(request);
    }
}
