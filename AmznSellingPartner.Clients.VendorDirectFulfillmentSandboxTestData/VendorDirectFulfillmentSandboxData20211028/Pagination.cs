namespace AmznSellingPartner.Clients.VendorDirectFulfillmentSandboxTestData.VendorDirectFulfillmentSandboxData20211028
{
	using Newtonsoft.Json;

	/// <summary>
	/// A generated string used to pass information to your next request. If NextToken is returned, pass the value of
	/// extToken to the next request. If NextToken is not returned, there are no more order items to return.
	/// </summary>
	public class Pagination : BaseClass
	{
		/// <summary>
		/// A generated token to be passed in the next request to retrieve the next set of results.
		/// </summary>
		[JsonProperty("nextToken")]
		public string NextToken { get; set; }
	}
}
