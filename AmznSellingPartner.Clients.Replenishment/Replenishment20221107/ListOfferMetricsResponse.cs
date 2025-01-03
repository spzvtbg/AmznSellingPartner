namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The response schema for the `listOfferMetrics` operation
	/// </summary>
	public class ListOfferMetricsResponse : BaseClass
	{
		/// <summary>
		/// A list of offers and associated metrics
		/// </summary>
		[JsonProperty("offers")]
		public List<ListOfferMetricsResponseOffer> Offers { get; set; }

		/// <summary>
		/// Use these parameters to paginate through the response
		/// </summary>
		[JsonProperty("pagination")]
		public PaginationResponse Pagination { get; set; }
	}
}
