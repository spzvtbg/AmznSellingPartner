namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Denotes the type for the carrier.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CarrierCodeType
	{
		/// <summary>
		/// Standard Carrier Alpha Code. Refer to [What is a Standard Carrier Alpha Code](https://www.help.cbp.gov/s/artic
		/// e/Article-1420?language=en_US) for more information.
		/// </summary>
		[EnumMember(Value = "SCAC")]
		SCAC,
	}
}
