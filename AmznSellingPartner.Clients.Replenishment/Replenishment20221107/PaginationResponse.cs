namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Use these parameters to paginate through the response.
	/// </summary>
	public class PaginationResponse : BaseClass
	{
		/// <summary>
		/// Total number of results matching the given filter criteria.
		/// </summary>
		[Minimum(0)]
		[JsonProperty("totalResults")]
		public long TotalResults { get; set; }
	}
}
