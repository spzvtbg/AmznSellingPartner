namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The policy for a delivery offering.
	/// </summary>
	public class DeliveryPolicy : BaseClass
	{
		/// <summary>
		/// Localized messaging for a delivery offering.
		/// </summary>
		[JsonProperty("message")]
		public DeliveryMessage Message { get; set; } 
	}
}
