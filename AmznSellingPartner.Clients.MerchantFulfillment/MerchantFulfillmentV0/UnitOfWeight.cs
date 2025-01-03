namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The unit of weight.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum UnitOfWeight
	{
		/// <summary>
		/// The unit of weight is ounces.
		/// </summary>
		[EnumMember(Value = "oz")]
		oz,

		/// <summary>
		/// The unit of weight is grams.
		/// </summary>
		[EnumMember(Value = "g")]
		g,
	}
}
