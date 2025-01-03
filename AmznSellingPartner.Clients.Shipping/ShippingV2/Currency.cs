namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The monetary value in the currency indicated, in ISO 4217 standard format.
	/// </summary>
	public class Currency : BaseClass
	{
		/// <summary>
		/// The monetary value.
		/// </summary>
		[IsRequired]
		[JsonProperty("value")]
		public double Value { get; set; }

		/// <summary>
		/// The ISO 4217 format 3-character currency code.
		/// </summary>
		[IsRequired]
		[MinLength(3)]
		[MaxLength(3)]
		[JsonProperty("unit")]
		public string Unit { get; set; }
	}
}
