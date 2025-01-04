namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Duration after manufacturing date during which the product is valid for consumption.
	/// </summary>
	public class Duration : BaseClass
	{
		/// <summary>
		/// Unit for duration.
		/// </summary>
		[JsonProperty("durationUnit")]
		[IsRequired]
		public DurationUnit DurationUnit { get; set; }

		/// <summary>
		/// Value for the duration in terms of the durationUnit.
		/// </summary>
		[JsonProperty("durationValue")]
		[IsRequired]
		public int DurationValue { get; set; }
	}
}
