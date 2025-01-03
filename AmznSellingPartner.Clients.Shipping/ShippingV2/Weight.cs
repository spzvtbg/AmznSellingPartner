namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The weight in the units indicated.
	/// </summary>
	public class Weight : BaseClass
	{
		/// <summary>
		/// The unit of measurement.
		/// </summary>
		[IsRequired]
		[JsonProperty("unit")]
		public Unit Unit { get; set; }

		/// <summary>
		/// The measurement value.
		/// </summary>
		[IsRequired]
		[JsonProperty("value")]
		public double Value { get; set; }
	}
}
