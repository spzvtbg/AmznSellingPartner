namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A response that contains the reference identifier for the newly created or updated outbound order. This
	/// includes an order ID.
	/// </summary>
	public class OutboundOrderReference : BaseClass
	{
		/// <summary>
		/// outbound order ID.
		/// </summary>
		[JsonProperty("orderId")]
		[IsRequired]
		public string OrderId { get; set; }
	}
}
