namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Supported preferences for the distribution order.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum OrderPreference
	{
		/// <summary>
		/// Represents a partial order case.
		/// </summary>
		[EnumMember(Value = "PARTIAL_ORDER")]
		PARTIAL_ORDER,
	}
}
