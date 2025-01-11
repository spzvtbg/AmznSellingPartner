namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	[HttpGet("/tax/invoices/2024-06-19/invoices")]
	public class AmznGetInvoicesRequest : BaseHttpRequest
	{
		/// <summary>
		/// The name of the transaction identifier filter. If you provide a value for this field, you must
		/// also provide a value for the `transactionIdentifierId` field.Use the `getInvoicesAttributes`
		/// operation to check `transactionIdentifierName` options.
		/// </summary>
		[InQuery("transactionIdentifierName")]
		public string TransactionIdentifierName { get; set; } 

		/// <summary>
		/// The maximum number of invoices you want to return in a single call.  Minimum: 1  Maximum:
		/// 200
		/// </summary>
		[InQuery("pageSize")]
		public int PageSize { get; set; } 

		/// <summary>
		/// The latest invoice creation date for invoices that you want to include in the response. Dates
		/// are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format.
		/// The default is the current date-time.
		/// </summary>
		[InQuery("dateEnd")]
		public DateTimeValue DateEnd { get; set; } 

		/// <summary>
		/// The response includes only the invoices that match the specified marketplace.
		/// </summary>
		[InQuery("marketplaceId")]
		[IsRequired]
		public string MarketplaceId { get; set; } 

		/// <summary>
		/// The marketplace-specific classification of the transaction type for which the invoice was created.
		/// Use the `getInvoicesAttributes` operation to check `transactionType` options.
		/// </summary>
		[InQuery("transactionType")]
		public string TransactionType { get; set; } 

		/// <summary>
		/// The ID of the transaction identifier filter. If you provide a value for this field, you must
		/// also provide a value for the `transactionIdentifierName` field.
		/// </summary>
		[InQuery("transactionIdentifierId")]
		public string TransactionIdentifierId { get; set; } 

		/// <summary>
		/// The earliest invoice creation date for invoices that you want to include in the response. Dates
		/// are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format.
		/// The default is 24 hours prior to the time of the request.
		/// </summary>
		[InQuery("dateStart")]
		public DateTimeValue DateStart { get; set; } 

		/// <summary>
		/// Return invoices with the specified series number.
		/// </summary>
		[InQuery("series")]
		public string Series { get; set; } 

		/// <summary>
		/// The response includes `nextToken` when the number of results exceeds the specified `pageSize`
		/// value. To get the next page of results, call the operation with this token and include the
		/// same arguments as the call that produced the token. To get a complete list, call this operation
		/// until `nextToken` is null. Note that this operation can return empty pages.
		/// </summary>
		[InQuery("nextToken")]
		public string NextToken { get; set; } 

		/// <summary>
		/// Sort the invoices in the response in ascending or descending order.
		/// </summary>
		[InQuery("sortOrder")]
		public SortOrder SortOrder { get; set; } 

		/// <summary>
		/// The marketplace-specific classification of the invoice type. Use the `getInvoicesAttributes`
		/// operation to check `invoiceType` options.
		/// </summary>
		[InQuery("invoiceType")]
		public string InvoiceType { get; set; } 

		/// <summary>
		/// A list of statuses that you can use to filter invoices. Use the `getInvoicesAttributes` operation
		/// to check invoice status options.  Min count: 1
		/// </summary>
		[InQuery("statuses")]
		[MinItems(1)]
		public CsvValue<string> Statuses { get; set; } 

		/// <summary>
		/// Return invoices that match this external ID. This is typically the Government Invoice ID.
		/// </summary>
		[InQuery("externalInvoiceId")]
		public string ExternalInvoiceId { get; set; } 

		/// <summary>
		/// The attribute by which you want to sort the invoices in the response.
		/// </summary>
		[InQuery("sortBy")]
		public SortBy SortBy { get; set; } 
	}
}
