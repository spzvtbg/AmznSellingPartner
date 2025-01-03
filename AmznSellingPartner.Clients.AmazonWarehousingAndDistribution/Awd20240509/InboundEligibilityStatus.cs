namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Enum denoting the package inbound eligibility.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum InboundEligibilityStatus
	{
		/// <summary>
		/// Eligible to inbound.
		/// </summary>
		[EnumMember(Value = "ELIGIBLE")]
		ELIGIBLE,

		/// <summary>
		/// Ineligible to inbound.
		/// </summary>
		[EnumMember(Value = "INELIGIBLE")]
		INELIGIBLE,
	}
}
