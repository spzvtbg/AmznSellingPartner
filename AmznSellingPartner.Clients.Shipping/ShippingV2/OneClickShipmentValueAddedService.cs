namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A value-added service to be applied to a shipping service purchase
	/// </summary>
	public class OneClickShipmentValueAddedService : BaseClass
	{
		/// <summary>
		/// The identifier of the selected value-added service
		/// </summary>
		[IsRequired]
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("amount")]
		public Currency Amount { get; set; }
	}
}
