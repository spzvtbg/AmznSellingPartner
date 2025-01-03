namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Specifies who will label the items. Options include `AMAZON`, `SELLER` or `NONE`.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum LabelOwner
	{
		/// <summary>
		/// Amazon provides the information.
		/// </summary>
		[EnumMember(Value = "AMAZON")]
		AMAZON,

		/// <summary>
		/// Seller provides the information.
		/// </summary>
		[EnumMember(Value = "SELLER")]
		SELLER,

		/// <summary>
		/// No owner is required for the labelling.
		/// </summary>
		[EnumMember(Value = "NONE")]
		NONE,
	}
}
