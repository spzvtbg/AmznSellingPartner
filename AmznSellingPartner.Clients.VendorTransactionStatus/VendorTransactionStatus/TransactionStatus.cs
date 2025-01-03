namespace AmznSellingPartner.Clients.VendorTransactionStatus.VendorTransactionStatus
{
	using Newtonsoft.Json;

	/// <summary>
	/// Represents the status of a transaction
	/// </summary>
	public class TransactionStatus : BaseClass
	{
		[JsonProperty("transactionStatusValue")]
		public Transaction TransactionStatusValue { get; set; }
	}
}
