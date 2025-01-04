namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Use these parameters to sort the response.
	/// </summary>
	public class ListOfferMetricsRequestSort : BaseClass
	{
		/// <summary>
		/// The sort order.
		/// </summary>
		[JsonProperty("order")]
		[IsRequired]
		public SortOrder Order { get; set; } 

		[JsonProperty("key")]
		[IsRequired]
		public ListOfferMetricsSortKey Key { get; set; } 
	}
}
