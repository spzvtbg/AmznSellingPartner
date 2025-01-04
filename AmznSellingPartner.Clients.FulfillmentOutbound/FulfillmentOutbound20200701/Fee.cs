namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Fee type and cost.
	/// </summary>
	public class Fee : BaseClass
	{
		/// <summary>
		/// The type of fee.
		/// </summary>
		[JsonProperty("name")]
		[IsRequired]
		public Name Name { get; set; }

		/// <summary>
		/// The amount of the fee.
		/// </summary>
		[JsonProperty("amount")]
		[IsRequired]
		public Money Amount { get; set; }
	}
}
