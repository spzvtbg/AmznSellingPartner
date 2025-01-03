namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A set of measurements for a three-dimensional object
	/// </summary>
	public class Dimensions : BaseClass
	{
		/// <summary>
		/// The length of the package
		/// </summary>
		[IsRequired]
		[JsonProperty("length")]
		public double Length { get; set; }

		/// <summary>
		/// The width of the package
		/// </summary>
		[IsRequired]
		[JsonProperty("width")]
		public double Width { get; set; }

		/// <summary>
		/// The height of the package
		/// </summary>
		[IsRequired]
		[JsonProperty("height")]
		public double Height { get; set; }

		/// <summary>
		/// The unit of measurement
		/// </summary>
		[IsRequired]
		[JsonProperty("unit")]
		public Unit Unit { get; set; }
	}
}
