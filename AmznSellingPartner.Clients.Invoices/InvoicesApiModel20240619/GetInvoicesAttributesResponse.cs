namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
	using Newtonsoft.Json;

	/// <summary>
	/// Success.
	/// </summary>
	public class GetInvoicesAttributesResponse : BaseClass
	{
		[JsonProperty("invoicesAttributes")]
		public InvoicesAttributes InvoicesAttributes { get; set; } 
	}
}
