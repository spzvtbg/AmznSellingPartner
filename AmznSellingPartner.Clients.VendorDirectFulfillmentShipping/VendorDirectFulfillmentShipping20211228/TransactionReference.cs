namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using Newtonsoft.Json;

	/// <summary>
	/// Response containing the transaction ID
	/// </summary>
	public class TransactionReference : BaseClass
	{
		/// <summary>
		/// GUID to identify this transaction
		/// This value can be used with the Transaction Status API to return the status of this transaction
		/// </summary>
		[JsonProperty("transactionId")]
		public string TransactionId { get; set; }
	}
}
