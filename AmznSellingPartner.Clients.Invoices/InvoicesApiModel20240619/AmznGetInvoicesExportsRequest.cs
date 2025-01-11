namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	[HttpGet("/tax/invoices/2024-06-19/exports")]
	public class AmznGetInvoicesExportsRequest : BaseHttpRequest
	{
		/// <summary>
		/// The returned exports match the specified marketplace.
		/// </summary>
		[InQuery("marketplaceId")]
		[IsRequired]
		public string MarketplaceId { get; set; } 

		/// <summary>
		/// The earliest export creation date and time for exports that you want to include in the response.
		/// Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time
		/// format. The default is 30 days ago.
		/// </summary>
		[InQuery("dateStart")]
		public DateTimeValue DateStart { get; set; } 

		/// <summary>
		/// The response includes `nextToken` when the number of results exceeds the specified `pageSize`
		/// value. To get the next page of results, call the operation with this token and include the
		/// same arguments as the call that produced the token. To get a complete list, call this operation
		/// until `nextToken` is null. Note that this operation can return empty pages.
		/// </summary>
		[InQuery("nextToken")]
		public string NextToken { get; set; } 

		/// <summary>
		/// The maximum number of invoices to return in a single call.  Minimum: 1  Maximum: 100
		/// </summary>
		[InQuery("pageSize")]
		public int PageSize { get; set; } 

		/// <summary>
		/// The latest export creation date and time for exports that you want to include in the response.
		/// Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time
		/// format. The default value is the time of the request.
		/// </summary>
		[InQuery("dateEnd")]
		public DateTimeValue DateEnd { get; set; } 

		/// <summary>
		/// Return exports matching the status specified.
		/// </summary>
		[InQuery("status")]
		public Status Status { get; set; } 
	}
}
