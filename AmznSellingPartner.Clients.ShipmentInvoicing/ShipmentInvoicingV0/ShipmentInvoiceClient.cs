namespace AmznSellingPartner.Clients.ShipmentInvoicing.ShipmentInvoicingV0
{
	using System;
	using System.Threading.Tasks;

	public class ShipmentInvoiceClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Returns the shipment details required to issue an invoice for the specified shipment.  **Usage Plan:**  | Rate
		/// (requests per second) | Burst | | ---- | ---- | | 1.133 | 25 |  The `x-amzn-RateLimit-Limit` response header r
		/// turns the usage plan rate limits that were applied to the requested operation, when available. The table above
		/// indicates the default rate and burst values for this operation. Selling partners whose business demands requir
		/// higher throughput may see higher rate and burst values than those shown here. For more information, see [Usag
		/// Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetShipmentDetailsGetResponse> GetShipmentDetailsAsync(GetShipmentDetailsGetRequest request)
		    => await this.SendAsync<GetShipmentDetailsGetResponse>(request);

		/// <summary>
		/// Submits a shipment invoice document for a given shipment.  **Usage Plan:**  | Rate (requests per second) | Bur
		/// t | | ---- | ---- | | 1.133 | 25 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate l
		/// mits that were applied to the requested operation, when available. The table above indicates the default rate
		/// nd burst values for this operation. Selling partners whose business demands require higher throughput may see
		/// igher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in t
		/// e Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<SubmitInvoicePostResponse> SubmitInvoiceAsync(SubmitInvoicePostRequest request)
		    => await this.SendAsync<SubmitInvoicePostResponse>(request);

		/// <summary>
		/// Returns the invoice status for the shipment you specify.  **Usage Plan:**  | Rate (requests per second) | Burs
		/// | | ---- | ---- | | 1.133 | 25 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate li
		/// its that were applied to the requested operation, when available. The table above indicates the default rate a
		/// d burst values for this operation. Selling partners whose business demands require higher throughput may see h
		/// gher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in th
		/// Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetInvoiceStatusGetResponse> GetInvoiceStatusAsync(GetInvoiceStatusGetRequest request)
		    => await this.SendAsync<GetInvoiceStatusGetResponse>(request);
	}
}
