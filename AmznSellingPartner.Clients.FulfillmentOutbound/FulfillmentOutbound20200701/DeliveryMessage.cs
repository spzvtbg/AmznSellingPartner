namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// Localized messaging for a delivery offering.
	/// </summary>
	public class DeliveryMessage : BaseClass
	{
		/// <summary>
		/// The message content for a delivery offering.
		/// </summary>
		[JsonProperty("text")]
		public string Text { get; set; }

		/// <summary>
		/// The locale for the message (for example, en_US).
		/// </summary>
		[JsonProperty("locale")]
		public string Locale { get; set; }
	}
}
