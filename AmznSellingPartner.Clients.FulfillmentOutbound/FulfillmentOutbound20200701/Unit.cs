namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum Unit
	{
		/// <summary>
		/// Kilograms
		/// </summary>
		[EnumMember(Value = "KG")]
		KG,

		/// <summary>
		/// Kilograms
		/// </summary>
		[EnumMember(Value = "KILOGRAMS")]
		KILOGRAMS,

		/// <summary>
		/// Pounds
		/// </summary>
		[EnumMember(Value = "LB")]
		LB,

		/// <summary>
		/// Pounds
		/// </summary>
		[EnumMember(Value = "POUNDS")]
		POUNDS,
	}
}
