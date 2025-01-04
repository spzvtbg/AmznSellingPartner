namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
	using Newtonsoft.Json;

	/// <summary>
	/// Success.
	/// </summary>
	public class GetInvoicesDocumentResponse : BaseClass
	{
		[JsonProperty("invoicesDocument")]
		public InvoicesDocument InvoicesDocument { get; set; } 
	}
}
