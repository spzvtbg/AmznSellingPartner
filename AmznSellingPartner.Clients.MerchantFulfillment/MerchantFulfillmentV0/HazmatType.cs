namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Hazardous materials options for a package. Consult the terms and conditions for each carrier for more
	/// information on hazardous materials.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum HazmatType
	{
		/// <summary>
		/// The package does not contain hazardous material.
		/// </summary>
		[EnumMember(Value = "None")]
		None,

		/// <summary>
		/// The package contains limited quantities of hazardous material.
		/// </summary>
		[EnumMember(Value = "LQHazmat")]
		LQHazmat,
	}
}
