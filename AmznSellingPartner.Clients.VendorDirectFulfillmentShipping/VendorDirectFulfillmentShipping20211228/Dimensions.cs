namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Physical dimensional measurements of a container
	/// </summary>
	public class Dimensions : BaseClass
	{
		/// <summary>
		/// The length of the container
		/// </summary>
		[IsRequired]
		[JsonProperty("length")]
		public Decimal Length { get; set; }

		/// <summary>
		/// The width of the container
		/// </summary>
		[IsRequired]
		[JsonProperty("width")]
		public Decimal Width { get; set; }

		/// <summary>
		/// The height of the container
		/// </summary>
		[IsRequired]
		[JsonProperty("height")]
		public Decimal Height { get; set; }

		/// <summary>
		/// The unit of measure for dimensions
		/// </summary>
		[IsRequired]
		[JsonProperty("unitOfMeasure")]
		public UnitOfMeasure UnitOfMeasure { get; set; }
	}
}
