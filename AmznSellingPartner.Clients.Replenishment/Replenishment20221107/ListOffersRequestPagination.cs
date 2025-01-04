namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Use these parameters to paginate through the response.
	/// </summary>
	public class ListOffersRequestPagination : BaseClass
	{
		/// <summary>
		/// The maximum number of results to return in the response.
		/// </summary>
		[JsonProperty("limit")]
		[IsRequired]
		[Minimum(1)]
		[Maximum(100)]
		public long Limit { get; set; } 

		/// <summary>
		/// The offset from which to retrieve the number of results specified by the `limit` value. The first result
		/// is at offset 0.
		/// </summary>
		[JsonProperty("offset")]
		[IsRequired]
		[Minimum(0)]
		[Maximum(9000)]
		public long Offset { get; set; } 
	}
}
