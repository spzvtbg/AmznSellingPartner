namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Liquid volume.
	/// </summary>
	public class LiquidVolume : BaseClass
	{
		/// <summary>
		/// The unit of measurement.
		/// </summary>
		[JsonProperty("Unit")]
		[IsRequired]
		public Unit Unit { get; set; }

		/// <summary>
		/// The measurement value.
		/// </summary>
		[JsonProperty("Value")]
		[IsRequired]
		public double Value { get; set; }
	}
}
