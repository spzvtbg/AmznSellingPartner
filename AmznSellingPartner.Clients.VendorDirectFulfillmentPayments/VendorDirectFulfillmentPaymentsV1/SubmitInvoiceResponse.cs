namespace AmznSellingPartner.Clients.VendorDirectFulfillmentPayments.VendorDirectFulfillmentPaymentsV1
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the submitInvoice operation.
	/// </summary>
	public class SubmitInvoiceResponse : BaseClass
	{
		/// <summary>
		/// The response payload for the submitInvoice operation.
		/// </summary>
		[JsonProperty("payload")]
		public TransactionReference Payload { get; set; }

		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
