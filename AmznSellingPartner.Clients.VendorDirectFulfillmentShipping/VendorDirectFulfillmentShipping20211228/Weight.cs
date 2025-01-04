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
		[JsonProperty("unitOfMeasure")]
		[IsRequired]
		public UnitOfMeasure UnitOfMeasure { get; set; } 

		/// <summary>
		/// The measurement value.
		/// </summary>
		[JsonProperty("value")]
		[IsRequired]
		public Decimal Value { get; set; } 
	}
}
