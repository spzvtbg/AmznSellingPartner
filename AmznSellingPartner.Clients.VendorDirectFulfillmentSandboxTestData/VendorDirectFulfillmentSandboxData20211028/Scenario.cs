namespace AmznSellingPartner.Clients.VendorDirectFulfillmentSandboxTestData.VendorDirectFulfillmentSandboxData20211028
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// A scenario test case response returned when the request is successful.
	/// </summary>
	public class Scenario : BaseClass
	{
		/// <summary>
		/// An identifier that identifies the type of scenario that user can use for testing.
		/// </summary>
		[IsRequired]
		[JsonProperty("scenarioId")]
		public string ScenarioId { get; set; }

		/// <summary>
		/// A list of orders that can be used by the caller to test each life cycle or scenario.
		/// </summary>
		[IsRequired]
		[JsonProperty("orders")]
		public List<TestOrder> Orders { get; set; }
	}
}
