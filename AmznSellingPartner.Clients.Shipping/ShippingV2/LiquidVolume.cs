namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Liquid Volume.
	/// </summary>
	public class LiquidVolume : BaseClass
	{
		/// <summary>
		/// The unit of measurement.
		/// </summary>
		[JsonProperty("unit")]
		[IsRequired]
		public Unit Unit { get; set; } 

		/// <summary>
		/// The measurement value.
		/// </summary>
		[JsonProperty("value")]
		[IsRequired]
		public double Value { get; set; } 
	}
}
