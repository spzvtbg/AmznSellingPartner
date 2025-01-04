namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
	using System;
	using System.Threading.Tasks;

	public class InvoicesClient(Uri baseAddress) : BaseHttpClient(baseAddress)
	{
		/// <summary>
		/// Returns marketplace-dependent schemas and their respective set of possible values.  **Usage Plan:**
		/// | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 1 |  The `x-amzn-RateLimit-Limit` response
		/// header returns the usage plan rate limits that were applied to the requested operation, when available.
		/// The preceding table indicates the default rate and burst values for this operation. Selling partners
		/// whose business demands require higher throughput may have higher rate and burst values than those shown
		/// here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https:
		/// //developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetInvoicesAttributesGetResponse> GetInvoicesAttributesAsync(GetInvoicesAttributesGetRequest request)
		    => await this.SendAsync<GetInvoicesAttributesGetResponse>(request);

		/// <summary>
		/// Returns the invoice document's ID and URL. Use the URL to download the ZIP file, which contains the invoices
		/// from the corresponding `createInvoicesExport` request.  **Usage Plan:**  | Rate (requests per second)
		/// | Burst | | ---- | ---- | | 0.0167 | 1 |  The `x-amzn-RateLimit-Limit` response header returns the usage
		/// plan rate limits that were applied to the requested operation, when available. The preceding table indicates
		/// the default rate and burst values for this operation. Selling partners whose business demands require
		/// higher throughput may have higher rate and burst values than those shown here. For more information,
		/// refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/
		/// sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetInvoicesDocumentGetResponse> GetInvoicesDocumentAsync(GetInvoicesDocumentGetRequest request)
		    => await this.SendAsync<GetInvoicesDocumentGetResponse>(request);

		/// <summary>
		/// Returns invoice exports details for exports that match the filters that you specify.  **Usage Plan:**
		/// | Rate (requests per second) | Burst | | ---- | ---- | | 0.1 | 20 |  The `x-amzn-RateLimit-Limit` response
		/// header returns the usage plan rate limits that were applied to the requested operation, when available.
		/// The preceding table indicates the default rate and burst values for this operation. Selling partners
		/// whose business demands require higher throughput may have higher rate and burst values than those shown
		/// here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https:
		/// //developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetInvoicesExportsGetResponse> GetInvoicesExportsAsync(GetInvoicesExportsGetRequest request)
		    => await this.SendAsync<GetInvoicesExportsGetResponse>(request);

		/// <summary>
		/// Creates an invoice export request.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- |
		/// ---- | | 0.167 | 1 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits
		/// that were applied to the requested operation, when available. The preceding table indicates the default
		/// rate and burst values for this operation. Selling partners whose business demands require higher throughput
		/// may have higher rate and burst values than those shown here. For more information, refer to [Usage Plans
		/// and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/sp-api/docs/usage-plan
		/// s-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CreateInvoicesExportPostResponse> CreateInvoicesExportAsync(CreateInvoicesExportPostRequest request)
		    => await this.SendAsync<CreateInvoicesExportPostResponse>(request);

		/// <summary>
		/// Returns invoice export details (including the `exportDocumentId`, if available) for the export that you
		/// specify.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 2 | 15 |  The `x-amzn-RateLimit-Limit`
		/// response header returns the usage plan rate limits that were applied to the requested operation, when
		/// available. The preceding table indicates the default rate and burst values for this operation. Selling
		/// partners whose business demands require higher throughput may have higher rate and burst values than
		/// those shown here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner
		/// API](https://developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetInvoicesExportGetResponse> GetInvoicesExportAsync(GetInvoicesExportGetRequest request)
		    => await this.SendAsync<GetInvoicesExportGetResponse>(request);

		/// <summary>
		/// Returns invoice details for the invoices that match the filters that you specify.  **Usage Plan:**  |
		/// Rate (requests per second) | Burst | | ---- | ---- | | 0.1 | 20 |  The `x-amzn-RateLimit-Limit` response
		/// header returns the usage plan rate limits that were applied to the requested operation, when available.
		/// The preceding table indicates the default rate and burst values for this operation. Selling partners
		/// whose business demands require higher throughput may have higher rate and burst values than those shown
		/// here. For more information, refer to [Usage Plans and Rate Limits in the Selling Partner API](https:
		/// //developer-docs.amazon.com/sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetInvoicesGetResponse> GetInvoicesAsync(GetInvoicesGetRequest request)
		    => await this.SendAsync<GetInvoicesGetResponse>(request);

		/// <summary>
		/// Returns invoice data for the specified invoice. This operation returns only a subset of the invoices
		/// data; refer to the response definition to get all the possible attributes. To get the full invoice, use
		/// the `createInvoicesExport` operation to start an export request.  **Usage Plan:**  | Rate (requests per
		/// second) | Burst | | ---- | ---- | | 2 | 15 |  The `x-amzn-RateLimit-Limit` response header returns the
		/// usage plan rate limits that were applied to the requested operation, when available. The preceding table
		/// indicates the default rate and burst values for this operation. Selling partners whose business demands
		/// require higher throughput may have higher rate and burst values than those shown here. For more information,
		/// refer to [Usage Plans and Rate Limits in the Selling Partner API](https://developer-docs.amazon.com/
		/// sp-api/docs/usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetInvoiceGetResponse> GetInvoiceAsync(GetInvoiceGetRequest request)
		    => await this.SendAsync<GetInvoiceGetResponse>(request);
	}
}
