namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// A list of paginated outbound orders filtered by the attributes passed in the request.
	/// </summary>
	public class OutboundListing : BaseClass
	{
		/// <summary>
		/// TA token that is used to retrieve the next page of results. The response includes `nextToken` when the number
		/// f results exceeds the specified `maxResults` value. To get the next page of results, call the operation with t
		/// is token and include the same arguments as the call that produced the token. To get a complete list, call this
		/// operation until `nextToken` is null. Note that this operation can return empty pages.
		/// </summary>
		[JsonProperty("nextToken")]
		public string NextToken { get; set; }

		/// <summary>
		/// List of outbound orders.
		/// </summary>
		[JsonProperty("outboundOrders")]
		public List<OutboundOrder> OutboundOrders { get; set; }
	}
}
