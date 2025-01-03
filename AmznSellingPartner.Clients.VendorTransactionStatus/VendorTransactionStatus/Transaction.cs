namespace AmznSellingPartner.Clients.VendorTransactionStatus.VendorTransactionStatus
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The transaction status.
	/// </summary>
	public class Transaction : BaseClass
	{
		/// <summary>
		/// The unique identifier returned in the 'transactionId' field in response to the post request of a specific tran
		/// action.
		/// </summary>
		[IsRequired]
		[JsonProperty("transactionId")]
		public string TransactionId { get; set; }

		/// <summary>
		/// Current processing status of the transaction.
		/// </summary>
		[IsRequired]
		[JsonProperty("status")]
		public Status Status { get; set; }

		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
