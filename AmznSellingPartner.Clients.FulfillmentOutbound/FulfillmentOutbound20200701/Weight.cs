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
		[JsonProperty("unit")]
		[IsRequired]
		public Unit Unit { get; set; } 

		/// <summary>
		/// The weight value.
		/// </summary>
		[JsonProperty("value")]
		[IsRequired]
		public string Value { get; set; } 
	}
}
