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
		[IsRequired]
		[JsonProperty("order")]
		public SortOrder Order { get; set; }

		[IsRequired]
		[JsonProperty("key")]
		public ListOfferMetricsSortKey Key { get; set; }
	}
}
