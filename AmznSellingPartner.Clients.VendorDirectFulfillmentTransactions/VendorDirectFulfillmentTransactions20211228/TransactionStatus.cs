namespace AmznSellingPartner.Clients.VendorDirectFulfillmentTransactions.VendorDirectFulfillmentTransactions20211228
{
	using Newtonsoft.Json;

	/// <summary>
	/// The payload for the getTransactionStatus operation.
	/// </summary>
	public class TransactionStatus : BaseClass
	{
		[JsonProperty("transactionStatus")]
		public Transaction TransactionStatusValue { get; set; }
	}
}
