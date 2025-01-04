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
		[JsonProperty("totalResults")]
		[Minimum(0)]
		public long TotalResults { get; set; } 
	}
}
