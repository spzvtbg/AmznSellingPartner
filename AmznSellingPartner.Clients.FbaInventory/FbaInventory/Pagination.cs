namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using Newtonsoft.Json;

	/// <summary>
	/// The process of returning the results to a request in batches of a defined size called pages
	/// This is done to exercise some control over result size and overall throughput
	/// It's a form of traffic management
	/// </summary>
	public class Pagination : BaseClass
	{
		/// <summary>
		/// A generated string used to retrieve the next page of the result
		/// If nextToken is returned, pass the value of nextToken to the next request
		/// If nextToken is not returned, there are no more items to return
		/// </summary>
		[JsonProperty("nextToken")]
		public string NextToken { get; set; }
	}
}
