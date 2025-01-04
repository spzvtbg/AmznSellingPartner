namespace AmznSellingPartner.Clients.VendorDirectFulfillmentSandboxTestData.VendorDirectFulfillmentSandboxData20211028
{
	using Newtonsoft.Json;

	/// <summary>
	/// The payload for the getOrderScenarios operation.
	/// </summary>
	public class TransactionStatus : BaseClass
	{
		[JsonProperty("transactionStatus")]
		public Transaction TransactionStatusValue { get; set; } 
	}
}
