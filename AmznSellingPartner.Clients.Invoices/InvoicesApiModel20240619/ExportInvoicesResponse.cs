namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
	using Newtonsoft.Json;

	/// <summary>
	/// Success
	/// </summary>
	public class ExportInvoicesResponse : BaseClass
	{
		/// <summary>
		/// The export identifier
		/// </summary>
		[JsonProperty("exportId")]
		public string ExportId { get; set; }
	}
}
