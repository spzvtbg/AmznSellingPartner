namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Enum to specify if returned shipment should include SKU quantity details
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SkuQuantitiesVisibility
	{
		/// <summary>
		/// Show the additional SKU quantity details
		/// </summary>
		[EnumMember(Value = "SHOW")]
		SHOW,

		/// <summary>
		/// Hide the additional SKU quantity details
		/// </summary>
		[EnumMember(Value = "HIDE")]
		HIDE,
	}
}
