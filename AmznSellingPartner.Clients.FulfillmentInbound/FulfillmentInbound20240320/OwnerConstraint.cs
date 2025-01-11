namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// A constraint that can apply to an individual owner. If no constraint is specified, both `AMAZON`
	/// and `SELLER` are acceptable.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum OwnerConstraint
	{
		/// <summary>
		/// Only `AMAZON` is accepted as an owner.
		/// </summary>
		[EnumMember(Value = "AMAZON_ONLY")]
		AMAZON_ONLY,

		/// <summary>
		/// Only `NONE` is accepted as an owner.
		/// </summary>
		[EnumMember(Value = "NONE_ONLY")]
		NONE_ONLY,

		/// <summary>
		/// Only `SELLER` is accepted as an owner.
		/// </summary>
		[EnumMember(Value = "SELLER_ONLY")]
		SELLER_ONLY,
	}
}
