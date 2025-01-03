namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// A list of inbound shipment summaries filtered by the attributes specified in the request
	/// </summary>
	public class ShipmentListing : BaseClass
	{
		/// <summary>
		/// A token that is used to retrieve the next page of results
		/// The response includes `nextToken` when the number of results exceeds the specified `maxResults` value
		/// To get the next page of results, call the operation with this token and include the same arguments as the cal
		/// that produced the token
		/// To get a complete list, call this operation until `nextToken` is null
		/// Note that this operation can return empty pages
		/// </summary>
		[JsonProperty("nextToken")]
		public string NextToken { get; set; }

		/// <summary>
		/// List of inbound shipment summaries
		/// </summary>
		[JsonProperty("shipments")]
		public List<InboundShipmentSummary> Shipments { get; set; }
	}
}
