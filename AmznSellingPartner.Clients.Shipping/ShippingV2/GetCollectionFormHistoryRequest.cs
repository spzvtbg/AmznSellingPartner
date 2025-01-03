namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// The request schema to get query collections form history API
	/// </summary>
	public class GetCollectionFormHistoryRequest : BaseClass
	{
		[JsonProperty("clientReferenceDetails")]
		public ClientReferenceDetails ClientReferenceDetails { get; set; }

		/// <summary>
		/// max Number of Results for query
		/// </summary>
		[JsonProperty("maxResults")]
		public int MaxResults { get; set; }

		[JsonProperty("carrierId")]
		public CarrierId CarrierId { get; set; }

		[JsonProperty("shipFromAddress")]
		public Address ShipFromAddress { get; set; }

		[JsonProperty("dateRange")]
		public DateRange DateRange { get; set; }
	}
}
