namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The owner of the preparations, if special preparations are required
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PrepOwner
	{
		/// <summary>
		/// Amazon provides the information
		/// </summary>
		[EnumMember(Value = "AMAZON")]
		AMAZON,

		/// <summary>
		/// The seller provides the information
		/// </summary>
		[EnumMember(Value = "SELLER")]
		SELLER,

		/// <summary>
		/// No owner is required for the preparations
		/// </summary>
		[EnumMember(Value = "NONE")]
		NONE,
	}
}
