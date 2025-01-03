namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Value for the order preference.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum OrderPreferenceValue
	{
		/// <summary>
		/// Sets the order preference.
		/// </summary>
		[EnumMember(Value = "SET")]
		SET,

		/// <summary>
		/// Unsets the order preference.
		/// </summary>
		[EnumMember(Value = "UNSET")]
		UNSET,
	}
}
