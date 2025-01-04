namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The request body for the `listOffers` operation.
	/// </summary>
	public class ListOffersRequest : BaseClass
	{
		/// <summary>
		/// Use these parameters to paginate through the response.
		/// </summary>
		[JsonProperty("pagination")]
		[IsRequired]
		public ListOffersRequestPagination Pagination { get; set; }

		/// <summary>
		/// Use these parameters to filter results. Any result must match all provided parameters. For any parameter
		/// that is an array, the result must match at least one element in the provided array.
		/// </summary>
		[JsonProperty("filters")]
		[IsRequired]
		public ListOffersRequestFilters Filters { get; set; }

		/// <summary>
		/// Use these parameters to sort the response.
		/// </summary>
		[JsonProperty("sort")]
		public ListOffersRequestSort Sort { get; set; }
	}
}
