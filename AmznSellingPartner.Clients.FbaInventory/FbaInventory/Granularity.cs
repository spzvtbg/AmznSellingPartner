namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using Newtonsoft.Json;

	/// <summary>
	/// Describes a granularity at which inventory data can be aggregated. For example, if you use Marketplace granula
	/// ity, the fulfillable quantity will reflect inventory that could be fulfilled in the given marketplace.
	/// </summary>
	public class Granularity : BaseClass
	{
		/// <summary>
		/// The granularity type for the inventory aggregation level.
		/// </summary>
		[JsonProperty("granularityType")]
		public GranularityType GranularityType { get; set; }

		/// <summary>
		/// The granularity ID for the specified granularity type. When granularityType is Marketplace, specify the market
		/// laceId.
		/// </summary>
		[JsonProperty("granularityId")]
		public string GranularityId { get; set; }
	}
}
