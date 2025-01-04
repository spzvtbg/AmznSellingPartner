namespace AmznSellingPartner.Clients.VendorDirectFulfillmentSandboxTestData.VendorDirectFulfillmentSandboxData20211028
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The set of test case data returned in response to the test data request.
	/// </summary>
	public class TestCaseData : BaseClass
	{
		/// <summary>
		/// Set of use cases that describes the possible test scenarios.
		/// </summary>
		[JsonProperty("scenarios")]
		public List<Scenario> Scenarios { get; set; } 
	}
}
