namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpGet("/tax/invoices/2024-06-19/documents/{invoicesDocumentId}")]
	public class GetInvoicesDocumentGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The export document identifier
		/// </summary>
		[InPath("invoicesDocumentId")]
		[IsRequired]
		[JsonProperty("invoicesDocumentId")]
		public string InvoicesDocumentId { get; set; }
	}
}
