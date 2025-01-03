namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/tax/invoices/2024-06-19/exports")]
	public class CreateInvoicesExportPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// Information required to create the export request
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public ExportInvoicesRequest Body { get; set; }
	}
}
