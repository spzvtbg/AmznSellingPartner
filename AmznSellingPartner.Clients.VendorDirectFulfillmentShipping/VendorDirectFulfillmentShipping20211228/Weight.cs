namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The weight.
	/// </summary>
	public class Weight : BaseClass
	{
		/// <summary>
		/// The unit of measurement.
		/// </summary>
		[IsRequired]
		[JsonProperty("unitOfMeasure")]
		public UnitOfMeasure UnitOfMeasure { get; set; }

		/// <summary>
		/// The measurement value.
		/// </summary>
		[IsRequired]
		[JsonProperty("value")]
		public Decimal Value { get; set; }
	}
}
