namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The size dimensions of the label.
	/// </summary>
	public class DocumentSize : BaseClass
	{
		/// <summary>
		/// The width of the document measured in the units specified.
		/// </summary>
		[JsonProperty("width")]
		[IsRequired]
		public double Width { get; set; } 

		/// <summary>
		/// The length of the document measured in the units specified.
		/// </summary>
		[JsonProperty("length")]
		[IsRequired]
		public double Length { get; set; } 

		/// <summary>
		/// The unit of measurement.
		/// </summary>
		[JsonProperty("unit")]
		[IsRequired]
		public Unit Unit { get; set; } 
	}
}
