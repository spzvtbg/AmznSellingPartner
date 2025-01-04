namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
	using Newtonsoft.Json;

	/// <summary>
	/// Response containing the transaction ID.
	/// </summary>
	public class TransactionId : BaseClass
	{
		/// <summary>
		/// GUID assigned by Amazon to identify this transaction. This value can be used with the Transaction Status
		/// API to return the status of this transaction.
		/// </summary>
		[JsonProperty("transactionId")]
		public string TransactionIdValue { get; set; } 
	}
}
