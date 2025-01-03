namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The weight.
	/// </summary>
	public class Weight : BaseClass
	{
		/// <summary>
		/// The unit of weight.
		/// </summary>
		[IsRequired]
		[JsonProperty("unit")]
		public Unit Unit { get; set; }

		/// <summary>
		/// The weight value.
		/// </summary>
		[IsRequired]
		[JsonProperty("value")]
		public string Value { get; set; }
	}
}
