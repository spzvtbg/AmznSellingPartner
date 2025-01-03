namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using System;
	using System.Threading.Tasks;

	public class ShippingClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Returns the available shipping service offerings.  **Usage Plan:**  | Rate (requests per second) | Burst | | -
		/// -- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that
		/// were applied to the requested operation, when available. The table above indicates the default rate and burst
		/// alues for this operation. Selling partners whose business demands require higher throughput may see higher rat
		/// and burst values then those shown here. For more information, see [Usage Plans and Rate Limits in the Selling
		/// Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetRatesPostResponse> GetRatesAsync(GetRatesPostRequest request)
		    => await this.SendAsync<GetRatesPostResponse>(request);

		/// <summary>
		/// Purchases the shipping service for a shipment using the best fit service offering. Returns purchase related de
		/// ails and documents.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 80 | 100 |  The
		/// `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested
		/// operation, when available. The table above indicates the default rate and burst values for this operation. Sel
		/// ing partners whose business demands require higher throughput may see higher rate and burst values then those
		/// hown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://develope
		/// -docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<DirectPurchaseShipmentPostResponse> DirectPurchaseShipmentAsync(DirectPurchaseShipmentPostRequest request)
		    => await this.SendAsync<DirectPurchaseShipmentPostResponse>(request);

		/// <summary>
		/// Purchases a shipping service and returns purchase related details and documents.  Note: You must complete the
		/// urchase within 10 minutes of rate creation by the shipping service provider. If you make the request after the
		/// 10 minutes have expired, you will receive an error response with the error code equal to "TOKEN_EXPIRED". If y
		/// u receive this error response, you must get the rates for the shipment again.  **Usage Plan:**  | Rate (reques
		/// s per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit` response header returns the
		/// usage plan rate limits that were applied to the requested operation, when available. The table above indicates
		/// the default rate and burst values for this operation. Selling partners whose business demands require higher t
		/// roughput may see higher rate and burst values then those shown here. For more information, see [Usage Plans an
		/// Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-li
		/// its-in-the-sp-api).
		/// </summary>
		public async Task<PurchaseShipmentPostResponse> PurchaseShipmentAsync(PurchaseShipmentPostRequest request)
		    => await this.SendAsync<PurchaseShipmentPostResponse>(request);

		/// <summary>
		/// Purchases a shipping service identifier and returns purchase-related details and documents.  **Usage Plan:**
		/// Rate (requests per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit` response head
		/// r returns the usage plan rate limits that were applied to the requested operation, when available. The table a
		/// ove indicates the default rate and burst values for this operation. Selling partners whose business demands re
		/// uire higher throughput may see higher rate and burst values then those shown here. For more information, see [
		/// sage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-pla
		/// s-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<OneClickShipmentPostResponse> OneClickShipmentAsync(OneClickShipmentPostRequest request)
		    => await this.SendAsync<OneClickShipmentPostResponse>(request);

		/// <summary>
		/// Returns tracking information for a purchased shipment.  **Usage Plan:**  | Rate (requests per second) | Burst
		/// | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits
		/// that were applied to the requested operation, when available. The table above indicates the default rate and b
		/// rst values for this operation. Selling partners whose business demands require higher throughput may see highe
		/// rate and burst values then those shown here. For more information, see [Usage Plans and Rate Limits in the Se
		/// ling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetTrackingGetResponse> GetTrackingAsync(GetTrackingGetRequest request)
		    => await this.SendAsync<GetTrackingGetResponse>(request);

		/// <summary>
		/// Returns the shipping documents associated with a package in a shipment.  **Usage Plan:**  | Rate (requests per
		/// second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit` response header returns the usage
		/// plan rate limits that were applied to the requested operation, when available. The table above indicates the d
		/// fault rate and burst values for this operation. Selling partners whose business demands require higher through
		/// ut may see higher rate and burst values then those shown here. For more information, see [Usage Plans and Rate
		/// Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-i
		/// -the-sp-api).
		/// </summary>
		public async Task<GetShipmentDocumentsGetResponse> GetShipmentDocumentsAsync(GetShipmentDocumentsGetRequest request)
		    => await this.SendAsync<GetShipmentDocumentsGetResponse>(request);

		/// <summary>
		/// Cancels a purchased shipment. Returns an empty object if the shipment is successfully cancelled.  **Usage Plan
		/// **  | Rate (requests per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit` response
		/// header returns the usage plan rate limits that were applied to the requested operation, when available. The ta
		/// le above indicates the default rate and burst values for this operation. Selling partners whose business deman
		/// s require higher throughput may see higher rate and burst values then those shown here. For more information,
		/// ee [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usag
		/// -plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CancelShipmentPutResponse> CancelShipmentAsync(CancelShipmentPutRequest request)
		    => await this.SendAsync<CancelShipmentPutResponse>(request);

		/// <summary>
		/// Returns the JSON schema to use for providing additional inputs when needed to purchase a shipping offering. Ca
		/// l the getAdditionalInputs operation when the response to a previous call to the getRates operation indicates t
		/// at additional inputs are required for the rate (shipping offering) that you want to purchase.  **Usage Plan:**
		/// | Rate (requests per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit` response he
		/// der returns the usage plan rate limits that were applied to the requested operation, when available. The table
		/// above indicates the default rate and burst values for this operation. Selling partners whose business demands
		/// equire higher throughput may see higher rate and burst values then those shown here. For more information, see
		/// [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-p
		/// ans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetAdditionalInputsGetResponse> GetAdditionalInputsAsync(GetAdditionalInputsGetRequest request)
		    => await this.SendAsync<GetAdditionalInputsGetResponse>(request);

		/// <summary>
		/// This API will return a list of input schema required to register a shipper account with the carrier.   **Usage
		/// Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit` res
		/// onse header returns the usage plan rate limits that were applied to the requested operation, when available. T
		/// e table above indicates the default rate and burst values for this operation. Selling partners whose business
		/// emands require higher throughput may see higher rate and burst values then those shown here. For more informat
		/// on, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs
		/// usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetCarrierAccountFormInputsGetResponse> GetCarrierAccountFormInputsAsync(GetCarrierAccountFormInputsGetRequest request)
		    => await this.SendAsync<GetCarrierAccountFormInputsGetResponse>(request);

		/// <summary>
		/// This API will return Get all carrier accounts for a merchant.   **Usage Plan:**  | Rate (requests per second)
		/// Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rat
		/// limits that were applied to the requested operation, when available. The table above indicates the default ra
		/// e and burst values for this operation. Selling partners whose business demands require higher throughput may s
		/// e higher rate and burst values then those shown here. For more information, see [Usage Plans and Rate Limits i
		/// the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-
		/// pi).
		/// </summary>
		public async Task<GetCarrierAccountsPutResponse> GetCarrierAccountsAsync(GetCarrierAccountsPutRequest request)
		    => await this.SendAsync<GetCarrierAccountsPutResponse>(request);

		/// <summary>
		/// This API associates/links the specified carrier account with the merchant.   **Usage Plan:**  | Rate (requests
		/// per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit` response header returns the u
		/// age plan rate limits that were applied to the requested operation, when available. The table above indicates t
		/// e default rate and burst values for this operation. Selling partners whose business demands require higher thr
		/// ughput may see higher rate and burst values then those shown here. For more information, see [Usage Plans and
		/// ate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limi
		/// s-in-the-sp-api).
		/// </summary>
		public async Task<LinkCarrierAccountPutResponse> LinkCarrierAccountAsync(LinkCarrierAccountPutRequest request)
		    => await this.SendAsync<LinkCarrierAccountPutResponse>(request);

		/// <summary>
		/// This API Unlink the specified carrier account with the merchant.   **Usage Plan:**  | Rate (requests per secon
		/// ) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan
		/// ate limits that were applied to the requested operation, when available. The table above indicates the default
		/// rate and burst values for this operation. Selling partners whose business demands require higher throughput ma
		/// see higher rate and burst values then those shown here. For more information, see [Usage Plans and Rate Limit
		/// in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-
		/// p-api).
		/// </summary>
		public async Task<UnlinkCarrierAccountPutResponse> UnlinkCarrierAccountAsync(UnlinkCarrierAccountPutRequest request)
		    => await this.SendAsync<UnlinkCarrierAccountPutResponse>(request);

		/// <summary>
		/// This API  Call to generate the collection form.   **Usage Plan:**  | Rate (requests per second) | Burst | | --
		/// - | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that
		/// ere applied to the requested operation, when available. The table above indicates the default rate and burst v
		/// lues for this operation. Selling partners whose business demands require higher throughput may see higher rate
		/// and burst values then those shown here. For more information, see [Usage Plans and Rate Limits in the Selling
		/// artner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GenerateCollectionFormPostResponse> GenerateCollectionFormAsync(GenerateCollectionFormPostRequest request)
		    => await this.SendAsync<GenerateCollectionFormPostResponse>(request);

		/// <summary>
		/// This API Call to get the history of the previously generated collection forms.   **Usage Plan:**  | Rate (requ
		/// sts per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit` response header returns t
		/// e usage plan rate limits that were applied to the requested operation, when available. The table above indicat
		/// s the default rate and burst values for this operation. Selling partners whose business demands require higher
		/// throughput may see higher rate and burst values then those shown here. For more information, see [Usage Plans
		/// nd Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-
		/// imits-in-the-sp-api).
		/// </summary>
		public async Task<GetCollectionFormHistoryPutResponse> GetCollectionFormHistoryAsync(GetCollectionFormHistoryPutRequest request)
		    => await this.SendAsync<GetCollectionFormHistoryPutResponse>(request);

		/// <summary>
		/// This API Get all unmanifested carriers with shipment locations. Any locations which has unmanifested shipments
		/// with an eligible carrier for manifesting shall be returned.   **Usage Plan:**  | Rate (requests per se
		/// ond) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit` response header returns the usage pl
		/// n rate limits that were applied to the requested operation, when available. The table above indicates the defa
		/// lt rate and burst values for this operation. Selling partners whose business demands require higher throughput
		/// may see higher rate and burst values then those shown here. For more information, see [Usage Plans and Rate Li
		/// its in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-t
		/// e-sp-api).
		/// </summary>
		public async Task<GetUnmanifestedShipmentsPutResponse> GetUnmanifestedShipmentsAsync(GetUnmanifestedShipmentsPutRequest request)
		    => await this.SendAsync<GetUnmanifestedShipmentsPutResponse>(request);

		/// <summary>
		/// This API reprint a collection form.   **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- |
		/// 80 | 100 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied
		/// to the requested operation, when available. The table above indicates the default rate and burst values for th
		/// s operation. Selling partners whose business demands require higher throughput may see higher rate and burst v
		/// lues then those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API]
		/// https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetCollectionFormGetResponse> GetCollectionFormAsync(GetCollectionFormGetRequest request)
		    => await this.SendAsync<GetCollectionFormGetResponse>(request);

		/// <summary>
		/// Returns a list of access points in proximity of input postal code.  **Usage Plan:**  | Rate (requests per seco
		/// d) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan
		/// rate limits that were applied to the requested operation, when available. The table above indicates the defaul
		/// rate and burst values for this operation. Selling partners whose business demands require higher throughput m
		/// y see higher rate and burst values then those shown here. For more information, see [Usage Plans and Rate Limi
		/// s in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the
		/// sp-api).
		/// </summary>
		public async Task<GetAccessPointsGetResponse> GetAccessPointsAsync(GetAccessPointsGetRequest request)
		    => await this.SendAsync<GetAccessPointsGetResponse>(request);
	}
}
