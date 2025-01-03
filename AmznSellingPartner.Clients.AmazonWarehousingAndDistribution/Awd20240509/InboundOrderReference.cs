namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A response that contains the reference identifiers for the newly created or updated inbound order
	/// Consists of an order ID and version
	/// </summary>
	public class InboundOrderReference : BaseClass
	{
		/// <summary>
		/// Order ID of the inbound order
		/// </summary>
		[IsRequired]
		[JsonProperty("orderId")]
		public string OrderId { get; set; }

		/// <summary>
		/// Order version of the inbound order
		/// </summary>
		[IsRequired]
		[JsonProperty("orderVersion")]
		public string OrderVersion { get; set; }
	}
}
