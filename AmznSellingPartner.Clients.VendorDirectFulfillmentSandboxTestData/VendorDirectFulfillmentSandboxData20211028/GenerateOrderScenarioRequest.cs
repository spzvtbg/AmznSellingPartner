namespace AmznSellingPartner.Clients.VendorDirectFulfillmentSandboxTestData.VendorDirectFulfillmentSandboxData20211028
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The request body for the generateOrderScenarios operation.
	/// </summary>
	public class GenerateOrderScenarioRequest : BaseClass
	{
		/// <summary>
		/// The list of test orders requested as indicated by party identifiers.
		/// </summary>
		[JsonProperty("orders")]
		public List<OrderScenarioRequest> Orders { get; set; }
	}
}
