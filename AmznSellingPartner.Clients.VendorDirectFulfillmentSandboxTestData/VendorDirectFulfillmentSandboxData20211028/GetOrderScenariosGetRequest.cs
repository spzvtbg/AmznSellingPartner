namespace AmznSellingPartner.Clients.VendorDirectFulfillmentSandboxTestData.VendorDirectFulfillmentSandboxData20211028
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpGet("/vendor/directFulfillment/sandbox/2021-10-28/transactions/{transactionId}")]
	public class GetOrderScenariosGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The transaction identifier returned in the response to the generateOrderScenarios operation.
		/// </summary>
		[InPath("transactionId")]
		[IsRequired]
		[JsonProperty("transactionId")]
		public string TransactionId { get; set; }
	}
}
