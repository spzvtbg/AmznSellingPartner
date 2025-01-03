namespace AmznSellingPartner.Clients.ShipmentInvoicing.ShipmentInvoicingV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the submitInvoice operation
	/// </summary>
	public class SubmitInvoiceResponse : BaseClass
	{
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
