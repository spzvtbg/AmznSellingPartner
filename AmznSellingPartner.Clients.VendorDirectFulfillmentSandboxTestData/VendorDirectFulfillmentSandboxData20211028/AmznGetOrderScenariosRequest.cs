namespace AmznSellingPartner.Clients.VendorDirectFulfillmentSandboxTestData.VendorDirectFulfillmentSandboxData20211028
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpGet("/vendor/directFulfillment/sandbox/2021-10-28/transactions/{transactionId}")]
	public class AmznGetOrderScenariosRequest : BaseHttpRequest
	{
		/// <summary>
		/// The transaction identifier returned in the response to the generateOrderScenarios operatio
		/// n.
		/// </summary>
		[InPath("transactionId")]
		[IsRequired]
		public string TransactionId { get; set; } 
	}
}
