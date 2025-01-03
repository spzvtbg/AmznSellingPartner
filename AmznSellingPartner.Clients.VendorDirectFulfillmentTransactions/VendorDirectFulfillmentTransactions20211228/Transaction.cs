namespace AmznSellingPartner.Clients.VendorDirectFulfillmentTransactions.VendorDirectFulfillmentTransactions20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The transaction status details.
	/// </summary>
	public class Transaction : BaseClass
	{
		/// <summary>
		/// The unique identifier sent in the 'transactionId' field in response to the post request of a specific
		/// transaction.
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

		/// <summary>
		/// Error code and message for the failed transaction. Only available when transaction status is 'Failur
		/// e'.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
