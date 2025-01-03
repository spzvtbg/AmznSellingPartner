namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpGet("/tax/invoices/2024-06-19/exports/{exportId}")]
	public class GetInvoicesExportGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The unique identifier for the export
		/// </summary>
		[InPath("exportId")]
		[IsRequired]
		[JsonProperty("exportId")]
		public string ExportId { get; set; }
	}
}
