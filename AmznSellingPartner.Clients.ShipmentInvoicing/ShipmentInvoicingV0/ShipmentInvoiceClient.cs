namespace AmznSellingPartner.Clients.ShipmentInvoicing.ShipmentInvoicingV0
{
	using System;
	using System.Threading.Tasks;

	public class ShipmentInvoiceClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Returns the shipment details required to issue an invoice for the specified shipment
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1
		/// 133 | 25 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied
		/// o the requested operation, when available
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may see higher rate and burst values than t
		/// ose shown here
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-l
		/// mits-in-the-sp-api)
		/// </summary>
		public async Task<GetShipmentDetailsGetResponse> GetShipmentDetailsAsync(GetShipmentDetailsGetRequest request)
		    => await this.SendAsync<GetShipmentDetailsGetResponse>(request);

		/// <summary>
		/// Submits a shipment invoice document for a given shipment
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1
		/// 133 | 25 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied
		/// o the requested operation, when available
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may see higher rate and burst values than t
		/// ose shown here
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-l
		/// mits-in-the-sp-api)
		/// </summary>
		public async Task<SubmitInvoicePostResponse> SubmitInvoiceAsync(SubmitInvoicePostRequest request)
		    => await this.SendAsync<SubmitInvoicePostResponse>(request);

		/// <summary>
		/// Returns the invoice status for the shipment you specify
		/// **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 1
		/// 133 | 25 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied
		/// o the requested operation, when available
		/// The table above indicates the default rate and burst values for this operation
		/// Selling partners whose business demands require higher throughput may see higher rate and burst values than t
		/// ose shown here
		/// For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-l
		/// mits-in-the-sp-api)
		/// </summary>
		public async Task<GetInvoiceStatusGetResponse> GetInvoiceStatusAsync(GetInvoiceStatusGetRequest request)
		    => await this.SendAsync<GetInvoiceStatusGetResponse>(request);
	}
}
