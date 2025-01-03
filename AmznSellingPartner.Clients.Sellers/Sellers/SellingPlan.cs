namespace AmznSellingPartner.Clients.Sellers.Sellers
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum SellingPlan
	{
		/// <summary>
		/// The seller has a professional selling plan.
		/// </summary>
		[EnumMember(Value = "PROFESSIONAL")]
		PROFESSIONAL,

		/// <summary>
		/// The seller has an individual selling plan.
		/// </summary>
		[EnumMember(Value = "INDIVIDUAL")]
		INDIVIDUAL,
	}
}
