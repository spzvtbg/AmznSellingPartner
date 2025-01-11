namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// A constraint that applies to all owners. If no constraint is specified, defer to any individual
	/// owner constraints.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AllOwnersConstraint
	{
		/// <summary>
		/// All owners must match.
		/// </summary>
		[EnumMember(Value = "MUST_MATCH")]
		MUST_MATCH,
	}
}
