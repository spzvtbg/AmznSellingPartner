namespace AmznSellingPartner.Clients.VendorInvoices.VendorInvoices
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the submitInvoices operation.
	/// </summary>
	public class SubmitInvoicesResponse : BaseClass
	{
		/// <summary>
		/// The response payload for the submitInvoices operation.
		/// </summary>
		[JsonProperty("payload")]
		public TransactionId Payload { get; set; } 

		[JsonProperty("errors")]
		public ErrorList Errors { get; set; } 
	}
}
