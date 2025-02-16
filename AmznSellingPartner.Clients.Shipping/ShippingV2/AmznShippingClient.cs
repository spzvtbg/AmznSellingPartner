namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using System;
    using System.Threading.Tasks;

    public class AmznShippingClient(Uri baseAddress) : BaseHttpClient(baseAddress)
    {
        /// <summary>
        /// Returns the available shipping service offerings.  **Usage Plan:**  | Rate (requests per second)
        /// | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit` response header returns
        /// the usage plan rate limits that were applied to the requested operation, when available. The
        /// table above indicates the default rate and burst values for this operation. Selling partners
        /// whose business demands require higher throughput may see higher rate and burst values then
        /// those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner
        /// API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-a
        /// pi).
        /// </summary>
        public async Task<AmznGetRatesResponse> GetRatesAsync(AmznGetRatesRequest request)
            => await SendAsync<AmznGetRatesResponse>(request);

        /// <summary>
        /// Purchases the shipping service for a shipment using the best fit service offering. Returns
        /// purchase related details and documents.  **Usage Plan:**  | Rate (requests per second) | Burst
        /// | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit` response header returns the usage
        /// plan rate limits that were applied to the requested operation, when available. The table above
        /// indicates the default rate and burst values for this operation. Selling partners whose business
        /// demands require higher throughput may see higher rate and burst values then those shown here.
        /// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https:/
        /// /developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznDirectPurchaseShipmentResponse> DirectPurchaseShipmentAsync(AmznDirectPurchaseShipmentRequest request)
            => await SendAsync<AmznDirectPurchaseShipmentResponse>(request);

        /// <summary>
        /// Purchases a shipping service and returns purchase related details and documents.  Note: You
        /// must complete the purchase within 10 minutes of rate creation by the shipping service provider.
        /// If you make the request after the 10 minutes have expired, you will receive an error response
        /// with the error code equal to "TOKEN_EXPIRED". If you receive this error response, you must
        /// get the rates for the shipment again.  **Usage Plan:**  | Rate (requests per second) | Burst
        /// | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit` response header returns the usage
        /// plan rate limits that were applied to the requested operation, when available. The table above
        /// indicates the default rate and burst values for this operation. Selling partners whose business
        /// demands require higher throughput may see higher rate and burst values then those shown here.
        /// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https:/
        /// /developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznPurchaseShipmentResponse> PurchaseShipmentAsync(AmznPurchaseShipmentRequest request)
            => await SendAsync<AmznPurchaseShipmentResponse>(request);

        /// <summary>
        /// Purchases a shipping service identifier and returns purchase-related details and documents.
        /// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The table above indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may see higher rate and burst
        /// values then those shown here. For more information, see [Usage Plans and Rate Limits in the
        /// Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-li
        /// mits-in-the-sp-api).
        /// </summary>
        public async Task<AmznOneClickShipmentResponse> OneClickShipmentAsync(AmznOneClickShipmentRequest request)
            => await SendAsync<AmznOneClickShipmentResponse>(request);

        /// <summary>
        /// Returns tracking information for a purchased shipment.  **Usage Plan:**  | Rate (requests per
        /// second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit` response header
        /// returns the usage plan rate limits that were applied to the requested operation, when available.
        /// The table above indicates the default rate and burst values for this operation. Selling partners
        /// whose business demands require higher throughput may see higher rate and burst values then
        /// those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner
        /// API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-a
        /// pi).
        /// </summary>
        public async Task<AmznGetTrackingResponse> GetTrackingAsync(AmznGetTrackingRequest request)
            => await SendAsync<AmznGetTrackingResponse>(request);

        /// <summary>
        /// Returns the shipping documents associated with a package in a shipment.  **Usage Plan:**  |
        /// Rate (requests per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The table above indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may see higher rate and burst
        /// values then those shown here. For more information, see [Usage Plans and Rate Limits in the
        /// Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-li
        /// mits-in-the-sp-api).
        /// </summary>
        public async Task<AmznGetShipmentDocumentsResponse> GetShipmentDocumentsAsync(AmznGetShipmentDocumentsRequest request)
            => await SendAsync<AmznGetShipmentDocumentsResponse>(request);

        /// <summary>
        /// Cancels a purchased shipment. Returns an empty object if the shipment is successfully cancelled.
        /// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The table above indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may see higher rate and burst
        /// values then those shown here. For more information, see [Usage Plans and Rate Limits in the
        /// Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-li
        /// mits-in-the-sp-api).
        /// </summary>
        public async Task<AmznCancelShipmentResponse> CancelShipmentAsync(AmznCancelShipmentRequest request)
            => await SendAsync<AmznCancelShipmentResponse>(request);

        /// <summary>
        /// Returns the JSON schema to use for providing additional inputs when needed to purchase a shipping
        /// offering. Call the getAdditionalInputs operation when the response to a previous call to the
        /// getRates operation indicates that additional inputs are required for the rate (shipping offering)
        /// that you want to purchase.  **Usage Plan:**  | Rate (requests per second) | Burst | | ----
        /// | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan
        /// rate limits that were applied to the requested operation, when available. The table above indicates
        /// the default rate and burst values for this operation. Selling partners whose business demands
        /// require higher throughput may see higher rate and burst values then those shown here. For more
        /// information, see [Usage Plans and Rate Limits in the Selling Partner API](https://develope
        /// r-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznGetAdditionalInputsResponse> GetAdditionalInputsAsync(AmznGetAdditionalInputsRequest request)
            => await SendAsync<AmznGetAdditionalInputsResponse>(request);

        /// <summary>
        /// This API will return a list of input schema required to register a shipper account with the
        /// carrier.   **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 80 | 100
        /// |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were
        /// applied to the requested operation, when available. The table above indicates the default rate
        /// and burst values for this operation. Selling partners whose business demands require higher
        /// throughput may see higher rate and burst values then those shown here. For more information,
        /// see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon
        /// .com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznGetCarrierAccountFormInputsResponse> GetCarrierAccountFormInputsAsync(AmznGetCarrierAccountFormInputsRequest request)
            => await SendAsync<AmznGetCarrierAccountFormInputsResponse>(request);

        /// <summary>
        /// This API will return Get all carrier accounts for a merchant.   **Usage Plan:**  | Rate (requests
        /// per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit` response header
        /// returns the usage plan rate limits that were applied to the requested operation, when available.
        /// The table above indicates the default rate and burst values for this operation. Selling partners
        /// whose business demands require higher throughput may see higher rate and burst values then
        /// those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner
        /// API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-a
        /// pi).
        /// </summary>
        public async Task<AmznGetCarrierAccountsResponse> GetCarrierAccountsAsync(AmznGetCarrierAccountsRequest request)
            => await SendAsync<AmznGetCarrierAccountsResponse>(request);

        /// <summary>
        /// This API associates/links the specified carrier account with the merchant.   **Usage Plan:**
        /// | Rate (requests per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The table above indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may see higher rate and burst
        /// values then those shown here. For more information, see [Usage Plans and Rate Limits in the
        /// Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-li
        /// mits-in-the-sp-api).
        /// </summary>
        public async Task<AmznLinkCarrierAccountResponse> LinkCarrierAccountAsync(AmznLinkCarrierAccountRequest request)
            => await SendAsync<AmznLinkCarrierAccountResponse>(request);

        /// <summary>
        /// This API Unlink the specified carrier account with the merchant.   **Usage Plan:**  | Rate
        /// (requests per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The table above indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may see higher rate and burst
        /// values then those shown here. For more information, see [Usage Plans and Rate Limits in the
        /// Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-li
        /// mits-in-the-sp-api).
        /// </summary>
        public async Task<AmznUnlinkCarrierAccountResponse> UnlinkCarrierAccountAsync(AmznUnlinkCarrierAccountRequest request)
            => await SendAsync<AmznUnlinkCarrierAccountResponse>(request);

        /// <summary>
        /// This API  Call to generate the collection form.   **Usage Plan:**  | Rate (requests per second)
        /// | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit` response header returns
        /// the usage plan rate limits that were applied to the requested operation, when available. The
        /// table above indicates the default rate and burst values for this operation. Selling partners
        /// whose business demands require higher throughput may see higher rate and burst values then
        /// those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner
        /// API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-a
        /// pi).
        /// </summary>
        public async Task<AmznGenerateCollectionFormResponse> GenerateCollectionFormAsync(AmznGenerateCollectionFormRequest request)
            => await SendAsync<AmznGenerateCollectionFormResponse>(request);

        /// <summary>
        /// This API Call to get the history of the previously generated collection forms.   **Usage Plan:**
        /// | Rate (requests per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The table above indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may see higher rate and burst
        /// values then those shown here. For more information, see [Usage Plans and Rate Limits in the
        /// Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-li
        /// mits-in-the-sp-api).
        /// </summary>
        public async Task<AmznGetCollectionFormHistoryResponse> GetCollectionFormHistoryAsync(AmznGetCollectionFormHistoryRequest request)
            => await SendAsync<AmznGetCollectionFormHistoryResponse>(request);

        /// <summary>
        /// This API Get all unmanifested carriers with shipment locations. Any locations which has unmanifested
        /// shipments         with an eligible carrier for manifesting shall be returned.   **Usage Plan:**
        /// | Rate (requests per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The table above indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may see higher rate and burst
        /// values then those shown here. For more information, see [Usage Plans and Rate Limits in the
        /// Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-li
        /// mits-in-the-sp-api).
        /// </summary>
        public async Task<AmznGetUnmanifestedShipmentsResponse> GetUnmanifestedShipmentsAsync(AmznGetUnmanifestedShipmentsRequest request)
            => await SendAsync<AmznGetUnmanifestedShipmentsResponse>(request);

        /// <summary>
        /// This API reprint a collection form.   **Usage Plan:**  | Rate (requests per second) | Burst
        /// | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit` response header returns the usage
        /// plan rate limits that were applied to the requested operation, when available. The table above
        /// indicates the default rate and burst values for this operation. Selling partners whose business
        /// demands require higher throughput may see higher rate and burst values then those shown here.
        /// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https:/
        /// /developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
        /// </summary>
        public async Task<AmznGetCollectionFormResponse> GetCollectionFormAsync(AmznGetCollectionFormRequest request)
            => await SendAsync<AmznGetCollectionFormResponse>(request);

        /// <summary>
        /// Returns a list of access points in proximity of input postal code.  **Usage Plan:**  | Rate
        /// (requests per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit`
        /// response header returns the usage plan rate limits that were applied to the requested operation,
        /// when available. The table above indicates the default rate and burst values for this operation.
        /// Selling partners whose business demands require higher throughput may see higher rate and burst
        /// values then those shown here. For more information, see [Usage Plans and Rate Limits in the
        /// Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-li
        /// mits-in-the-sp-api).
        /// </summary>
        public async Task<AmznGetAccessPointsResponse> GetAccessPointsAsync(AmznGetAccessPointsRequest request)
            => await SendAsync<AmznGetAccessPointsResponse>(request);
    }
}
