namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A set of measurements for a three-dimensional object.
	/// </summary>
	public class Dimensions : BaseClass
	{
		/// <summary>
		/// The length of the package.
		/// </summary>
		[JsonProperty("length")]
		[IsRequired]
		public double Length { get; set; } 

		/// <summary>
		/// The width of the package.
		/// </summary>
		[JsonProperty("width")]
		[IsRequired]
		public double Width { get; set; } 

		/// <summary>
		/// The height of the package.
		/// </summary>
		[JsonProperty("height")]
		[IsRequired]
		public double Height { get; set; } 

		/// <summary>
		/// The unit of measurement.
		/// </summary>
		[JsonProperty("unit")]
		[IsRequired]
		public Unit Unit { get; set; } 
	}
}
