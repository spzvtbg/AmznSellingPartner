namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using System;
	using System.Threading.Tasks;

	public class ShippingClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Returns the available shipping service offerings
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-
		/// imit` response header returns the usage plan rate limits that were applied to the requested operation, when av
		/// ilable
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may see higher rate and burst values then t
		/// ose shown here
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<GetRatesPostResponse> GetRatesAsync(GetRatesPostRequest request)
		    => await this.SendAsync<GetRatesPostResponse>(request);

		/// <summary>
		/// Purchases the shipping service for a shipment using the best fit service offering
		/// Returns purchase related details and documents
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-
		/// imit` response header returns the usage plan rate limits that were applied to the requested operation, when av
		/// ilable
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may see higher rate and burst values then t
		/// ose shown here
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<DirectPurchaseShipmentPostResponse> DirectPurchaseShipmentAsync(DirectPurchaseShipmentPostRequest request)
		    => await this.SendAsync<DirectPurchaseShipmentPostResponse>(request);

		/// <summary>
		/// Purchases a shipping service and returns purchase related details and documents
		/// Note: You must complete the purchase within 10 minutes of rate creation by the shipping service provider
		/// If you make the request after the 10 minutes have expired, you will receive an error response with the error
		/// ode equal to "TOKEN_EXPIRED"
		/// If you receive this error response, you must get the rates for the shipment again
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-
		/// imit` response header returns the usage plan rate limits that were applied to the requested operation, when av
		/// ilable
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may see higher rate and burst values then t
		/// ose shown here
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<PurchaseShipmentPostResponse> PurchaseShipmentAsync(PurchaseShipmentPostRequest request)
		    => await this.SendAsync<PurchaseShipmentPostResponse>(request);

		/// <summary>
		/// Purchases a shipping service identifier and returns purchase-related details and documents
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-
		/// imit` response header returns the usage plan rate limits that were applied to the requested operation, when av
		/// ilable
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may see higher rate and burst values then t
		/// ose shown here
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<OneClickShipmentPostResponse> OneClickShipmentAsync(OneClickShipmentPostRequest request)
		    => await this.SendAsync<OneClickShipmentPostResponse>(request);

		/// <summary>
		/// Returns tracking information for a purchased shipment
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-
		/// imit` response header returns the usage plan rate limits that were applied to the requested operation, when av
		/// ilable
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may see higher rate and burst values then t
		/// ose shown here
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<GetTrackingGetResponse> GetTrackingAsync(GetTrackingGetRequest request)
		    => await this.SendAsync<GetTrackingGetResponse>(request);

		/// <summary>
		/// Returns the shipping documents associated with a package in a shipment
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-
		/// imit` response header returns the usage plan rate limits that were applied to the requested operation, when av
		/// ilable
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may see higher rate and burst values then t
		/// ose shown here
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<GetShipmentDocumentsGetResponse> GetShipmentDocumentsAsync(GetShipmentDocumentsGetRequest request)
		    => await this.SendAsync<GetShipmentDocumentsGetResponse>(request);

		/// <summary>
		/// Cancels a purchased shipment
		/// Returns an empty object if the shipment is successfully cancelled
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-
		/// imit` response header returns the usage plan rate limits that were applied to the requested operation, when av
		/// ilable
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may see higher rate and burst values then t
		/// ose shown here
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<CancelShipmentPutResponse> CancelShipmentAsync(CancelShipmentPutRequest request)
		    => await this.SendAsync<CancelShipmentPutResponse>(request);

		/// <summary>
		/// Returns the JSON schema to use for providing additional inputs when needed to purchase a shipping offering
		/// Call the getAdditionalInputs operation when the response to a previous call to the getRates operation indicat
		/// s that additional inputs are required for the rate (shipping offering) that you want to purchase
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-
		/// imit` response header returns the usage plan rate limits that were applied to the requested operation, when av
		/// ilable
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may see higher rate and burst values then t
		/// ose shown here
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<GetAdditionalInputsGetResponse> GetAdditionalInputsAsync(GetAdditionalInputsGetRequest request)
		    => await this.SendAsync<GetAdditionalInputsGetResponse>(request);

		/// <summary>
		/// This API will return a list of input schema required to register a shipper account with the carrier
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit
		/// Limit` response header returns the usage plan rate limits that were applied to the requested operation, when a
		/// ailable
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may see higher rate and burst values then t
		/// ose shown here
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<GetCarrierAccountFormInputsGetResponse> GetCarrierAccountFormInputsAsync(GetCarrierAccountFormInputsGetRequest request)
		    => await this.SendAsync<GetCarrierAccountFormInputsGetResponse>(request);

		/// <summary>
		/// This API will return Get all carrier accounts for a merchant
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit
		/// Limit` response header returns the usage plan rate limits that were applied to the requested operation, when a
		/// ailable
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may see higher rate and burst values then t
		/// ose shown here
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<GetCarrierAccountsPutResponse> GetCarrierAccountsAsync(GetCarrierAccountsPutRequest request)
		    => await this.SendAsync<GetCarrierAccountsPutResponse>(request);

		/// <summary>
		/// This API associates/links the specified carrier account with the merchant
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit
		/// Limit` response header returns the usage plan rate limits that were applied to the requested operation, when a
		/// ailable
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may see higher rate and burst values then t
		/// ose shown here
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<LinkCarrierAccountPutResponse> LinkCarrierAccountAsync(LinkCarrierAccountPutRequest request)
		    => await this.SendAsync<LinkCarrierAccountPutResponse>(request);

		/// <summary>
		/// This API Unlink the specified carrier account with the merchant
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit
		/// Limit` response header returns the usage plan rate limits that were applied to the requested operation, when a
		/// ailable
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may see higher rate and burst values then t
		/// ose shown here
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<UnlinkCarrierAccountPutResponse> UnlinkCarrierAccountAsync(UnlinkCarrierAccountPutRequest request)
		    => await this.SendAsync<UnlinkCarrierAccountPutResponse>(request);

		/// <summary>
		/// This API  Call to generate the collection form
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit
		/// Limit` response header returns the usage plan rate limits that were applied to the requested operation, when a
		/// ailable
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may see higher rate and burst values then t
		/// ose shown here
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<GenerateCollectionFormPostResponse> GenerateCollectionFormAsync(GenerateCollectionFormPostRequest request)
		    => await this.SendAsync<GenerateCollectionFormPostResponse>(request);

		/// <summary>
		/// This API Call to get the history of the previously generated collection forms
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit
		/// Limit` response header returns the usage plan rate limits that were applied to the requested operation, when a
		/// ailable
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may see higher rate and burst values then t
		/// ose shown here
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<GetCollectionFormHistoryPutResponse> GetCollectionFormHistoryAsync(GetCollectionFormHistoryPutRequest request)
		    => await this.SendAsync<GetCollectionFormHistoryPutResponse>(request);

		/// <summary>
		/// This API Get all unmanifested carriers with shipment locations
		/// Any locations which has unmanifested shipments         with an eligible carrier for manifesting shall be retu
		/// ned
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit
		/// Limit` response header returns the usage plan rate limits that were applied to the requested operation, when a
		/// ailable
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may see higher rate and burst values then t
		/// ose shown here
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<GetUnmanifestedShipmentsPutResponse> GetUnmanifestedShipmentsAsync(GetUnmanifestedShipmentsPutRequest request)
		    => await this.SendAsync<GetUnmanifestedShipmentsPutResponse>(request);

		/// <summary>
		/// This API reprint a collection form
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit
		/// Limit` response header returns the usage plan rate limits that were applied to the requested operation, when a
		/// ailable
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may see higher rate and burst values then t
		/// ose shown here
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<GetCollectionFormGetResponse> GetCollectionFormAsync(GetCollectionFormGetRequest request)
		    => await this.SendAsync<GetCollectionFormGetResponse>(request);

		/// <summary>
		/// Returns a list of access points in proximity of input postal code
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 80 | 100 |  The `x-amzn-RateLimit-
		/// imit` response header returns the usage plan rate limits that were applied to the requested operation, when av
		/// ilable
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may see higher rate and burst values then t
		/// ose shown here
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs
		/// amazon
		/// com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api)
		/// </summary>
		public async Task<GetAccessPointsGetResponse> GetAccessPointsAsync(GetAccessPointsGetRequest request)
		    => await this.SendAsync<GetAccessPointsGetResponse>(request);
	}
}
