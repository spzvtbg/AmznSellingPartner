namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum CustomerMembership
	{
		/// <summary>
		/// PRIME
		/// </summary>
		[EnumMember(Value = "PRIME")]
		PRIME,

		/// <summary>
		/// NON_PRIME
		/// </summary>
		[EnumMember(Value = "NON_PRIME")]
		NON_PRIME,
	}
}
