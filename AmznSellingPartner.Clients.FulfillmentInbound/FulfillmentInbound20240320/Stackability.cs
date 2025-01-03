namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Indicates whether pallets will be stacked when carrier arrives for pick-up
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Stackability
	{
		/// <summary>
		/// A pallet that can be stacked on top of another pallet
		/// </summary>
		[EnumMember(Value = "STACKABLE")]
		STACKABLE,

		/// <summary>
		/// A pallet that cannot be stacked on top of another pallet
		/// </summary>
		[EnumMember(Value = "NON_STACKABLE")]
		NON_STACKABLE,
	}
}
