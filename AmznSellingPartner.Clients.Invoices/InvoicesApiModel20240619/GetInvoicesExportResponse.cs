namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
	using Newtonsoft.Json;

	/// <summary>
	/// Success
	/// </summary>
	public class GetInvoicesExportResponse : BaseClass
	{
		[JsonProperty("export")]
		public Export Export { get; set; }
	}
}
