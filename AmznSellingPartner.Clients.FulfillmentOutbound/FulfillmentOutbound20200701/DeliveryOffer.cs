namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// An available offer for delivery of a product
	/// </summary>
	public class DeliveryOffer : BaseClass
	{
		/// <summary>
		/// The timestamp at which a delivery offer expires
		/// </summary>
		[JsonProperty("expiresAt")]
		public Timestamp ExpiresAt { get; set; }

		/// <summary>
		/// The range between which delivery is expected
		/// </summary>
		[JsonProperty("dateRange")]
		public DateRange DateRange { get; set; }

		/// <summary>
		/// The policy for a delivery offer, including localized messaging
		/// </summary>
		[JsonProperty("policy")]
		public DeliveryPolicy Policy { get; set; }
	}
}
