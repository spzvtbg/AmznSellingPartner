namespace AmznSellingPartner.Clients.VendorDirectFulfillmentSandboxTestData.VendorDirectFulfillmentSandboxData20211028
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The transaction details including the status
	/// If the transaction was successful, also includes the requested test order data
	/// </summary>
	public class Transaction : BaseClass
	{
		/// <summary>
		/// The unique identifier returned in the response to the generateOrderScenarios request
		/// </summary>
		[IsRequired]
		[JsonProperty("transactionId")]
		public string TransactionId { get; set; }

		/// <summary>
		/// The current processing status of the transaction
		/// </summary>
		[IsRequired]
		[JsonProperty("status")]
		public Status Status { get; set; }

		/// <summary>
		/// Test case data for the transaction
		/// Only available when the transaction status is SUCCESS
		/// </summary>
		[JsonProperty("testCaseData")]
		public TestCaseData TestCaseData { get; set; }
	}
}
