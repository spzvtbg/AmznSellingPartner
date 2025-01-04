namespace AmznSellingPartner.Clients.VendorTransactionStatus.VendorTransactionStatus
{
	using Newtonsoft.Json;

	/// <summary>
	/// Represents the status of a transaction.
	/// </summary>
	public class TransactionStatus : BaseClass
	{
		[JsonProperty("transactionStatus")]
		public Transaction TransactionStatusValue { get; set; } 
	}
}
