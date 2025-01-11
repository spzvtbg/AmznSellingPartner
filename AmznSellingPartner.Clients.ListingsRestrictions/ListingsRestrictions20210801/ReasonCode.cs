namespace AmznSellingPartner.Clients.ListingsRestrictions.ListingsRestrictions20210801
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum ReasonCode
	{
		/// <summary>
		/// Approval is required to create a listing for the specified ASIN. A path forward link will be
		/// provided that may allow Selling Partners to remove the restriction.
		/// </summary>
		[EnumMember(Value = "APPROVAL_REQUIRED")]
		APPROVAL_REQUIRED,

		/// <summary>
		/// The specified ASIN does not exist in the requested marketplace.
		/// </summary>
		[EnumMember(Value = "ASIN_NOT_FOUND")]
		ASIN_NOT_FOUND,

		/// <summary>
		/// Not eligible to create a listing for the specified ASIN. No path forward link will be provided
		/// to remove the restriction.
		/// </summary>
		[EnumMember(Value = "NOT_ELIGIBLE")]
		NOT_ELIGIBLE,
	}
}
