namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpGet("/tax/invoices/2024-06-19/documents/{invoicesDocumentId}")]
	public class AmznGetInvoicesDocumentRequest : BaseHttpRequest
	{
		/// <summary>
		/// The export document identifier.
		/// </summary>
		[InPath("invoicesDocumentId")]
		[IsRequired]
		public string InvoicesDocumentId { get; set; } 
	}
}
