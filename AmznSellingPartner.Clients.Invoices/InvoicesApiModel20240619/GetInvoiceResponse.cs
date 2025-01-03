namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
	using Newtonsoft.Json;

	/// <summary>
	/// Success.
	/// </summary>
	public class GetInvoiceResponse : BaseClass
	{
		[JsonProperty("invoice")]
		public Invoice Invoice { get; set; }
	}
}
