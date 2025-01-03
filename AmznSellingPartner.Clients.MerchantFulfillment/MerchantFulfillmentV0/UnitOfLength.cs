namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The unit of length.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum UnitOfLength
	{
		/// <summary>
		/// The unit of length is inches.
		/// </summary>
		[EnumMember(Value = "inches")]
		inches,

		/// <summary>
		/// The unit of length is centimeters.
		/// </summary>
		[EnumMember(Value = "centimeters")]
		centimeters,
	}
}
