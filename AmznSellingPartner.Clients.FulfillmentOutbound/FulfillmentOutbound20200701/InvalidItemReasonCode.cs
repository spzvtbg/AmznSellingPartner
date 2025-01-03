namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// A code for why the item is invalid for return
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum InvalidItemReasonCode
	{
		/// <summary>
		/// The item was not found in a fulfillment order
		/// </summary>
		[EnumMember(Value = "InvalidValues")]
		InvalidValues,

		/// <summary>
		/// A fulfillment return has already been requested for this item
		/// </summary>
		[EnumMember(Value = "DuplicateRequest")]
		DuplicateRequest,

		/// <summary>
		/// The fulfillment order containing this item has not yet shipped
		/// </summary>
		[EnumMember(Value = "NoCompletedShipItems")]
		NoCompletedShipItems,

		/// <summary>
		/// All item quantity available for return has been allocated to other return items
		/// </summary>
		[EnumMember(Value = "NoReturnableQuantity")]
		NoReturnableQuantity,
	}
}
