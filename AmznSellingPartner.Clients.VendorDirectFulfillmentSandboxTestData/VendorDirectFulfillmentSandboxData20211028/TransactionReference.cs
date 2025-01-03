namespace AmznSellingPartner.Clients.VendorDirectFulfillmentSandboxTestData.VendorDirectFulfillmentSandboxData20211028
{
	using Newtonsoft.Json;

	/// <summary>
	/// A GUID assigned by Amazon to identify this transaction.
	/// </summary>
	public class TransactionReference : BaseClass
	{
		/// <summary>
		/// A GUID (Globally Unique Identifier) assigned by Amazon to uniquely identify the transaction.
		/// </summary>
		[JsonProperty("transactionId")]
		public string TransactionId { get; set; }
	}
}
