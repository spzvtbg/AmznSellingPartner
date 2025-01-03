namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response payload for the SubmitShipmentConfirmations operation.
	/// </summary>
	public class TransactionReference : BaseClass
	{
		/// <summary>
		/// GUID assigned by Buyer to identify this transaction. This value can be used with the Transaction Status API to
		/// return the status of this transaction.
		/// </summary>
		[JsonProperty("transactionId")]
		public string TransactionId { get; set; }
	}
}
