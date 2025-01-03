namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum SkuQuantities
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
