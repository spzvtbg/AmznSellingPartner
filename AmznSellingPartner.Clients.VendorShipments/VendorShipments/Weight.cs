namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The weight of the shipment
	/// </summary>
	public class Weight : BaseClass
	{
		/// <summary>
		/// The unit of measurement
		/// </summary>
		[IsRequired]
		[JsonProperty("unitOfMeasure")]
		public UnitOfMeasure UnitOfMeasure { get; set; }

		/// <summary>
		/// The measurement value
		/// </summary>
		[IsRequired]
		[JsonProperty("value")]
		public Decimal Value { get; set; }
	}
}
