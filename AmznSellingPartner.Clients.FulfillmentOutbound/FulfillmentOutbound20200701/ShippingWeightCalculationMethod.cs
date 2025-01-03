namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum ShippingWeightCalculationMethod
	{
		/// <summary>
		/// Based on the actual weight of the items.
		/// </summary>
		[EnumMember(Value = "Package")]
		Package,

		/// <summary>
		/// Based on the cubic space that the items occupy.
		/// </summary>
		[EnumMember(Value = "Dimensional")]
		Dimensional,
	}
}
