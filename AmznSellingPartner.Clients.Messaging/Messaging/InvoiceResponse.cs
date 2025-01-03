namespace AmznSellingPartner.Clients.Messaging.Messaging
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the sendInvoice operation
	/// </summary>
	public class InvoiceResponse : BaseClass
	{
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
