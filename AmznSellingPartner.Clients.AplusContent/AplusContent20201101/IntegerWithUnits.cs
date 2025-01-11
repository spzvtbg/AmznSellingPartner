namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A whole number dimension and its unit of measurement. For example, this can represent 100
	/// pixels.
	/// </summary>
	public class IntegerWithUnits : BaseClass
	{
		/// <summary>
		/// The dimension value.
		/// </summary>
		[JsonProperty("value")]
		[IsRequired]
		public int Value { get; set; } 

		/// <summary>
		/// The unit of measurement.
		/// </summary>
		[JsonProperty("units")]
		[IsRequired]
		public string Units { get; set; } 
	}
}
