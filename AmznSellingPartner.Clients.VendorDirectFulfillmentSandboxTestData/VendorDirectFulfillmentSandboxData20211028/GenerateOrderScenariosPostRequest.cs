namespace AmznSellingPartner.Clients.VendorDirectFulfillmentSandboxTestData.VendorDirectFulfillmentSandboxData20211028
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/vendor/directFulfillment/sandbox/2021-10-28/orders")]
	public class GenerateOrderScenariosPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// The request payload containing parameters for generating test order data scenarios.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public GenerateOrderScenarioRequest Body { get; set; }
	}
}
