namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Indicates if the return item has been processed by a fulfillment center
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum FulfillmentReturnItemStatus
	{
		/// <summary>
		/// The return item has not yet been processed by a fulfillment center
		/// </summary>
		[EnumMember(Value = "New")]
		New,

		/// <summary>
		/// The return item has been processed by a fulfillment center
		/// </summary>
		[EnumMember(Value = "Processed")]
		Processed,
	}
}
