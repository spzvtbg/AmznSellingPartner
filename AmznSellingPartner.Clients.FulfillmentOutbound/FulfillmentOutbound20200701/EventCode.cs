namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The event code for the delivery event
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EventCode
	{
		/// <summary>
		/// Carrier notified to pick up package
		/// </summary>
		[EnumMember(Value = "EVENT_101")]
		EVENT_101,

		/// <summary>
		/// Shipment picked up from seller's facility
		/// </summary>
		[EnumMember(Value = "EVENT_102")]
		EVENT_102,

		/// <summary>
		/// Arrival scan
		/// </summary>
		[EnumMember(Value = "EVENT_201")]
		EVENT_201,

		/// <summary>
		/// Departure scan
		/// </summary>
		[EnumMember(Value = "EVENT_202")]
		EVENT_202,

		/// <summary>
		/// Arrived at destination country
		/// </summary>
		[EnumMember(Value = "EVENT_203")]
		EVENT_203,

		/// <summary>
		/// Initiated customs clearance process
		/// </summary>
		[EnumMember(Value = "EVENT_204")]
		EVENT_204,

		/// <summary>
		/// Completed customs clearance process
		/// </summary>
		[EnumMember(Value = "EVENT_205")]
		EVENT_205,

		/// <summary>
		/// In transit to pickup location
		/// </summary>
		[EnumMember(Value = "EVENT_206")]
		EVENT_206,

		/// <summary>
		/// Delivered
		/// </summary>
		[EnumMember(Value = "EVENT_301")]
		EVENT_301,

		/// <summary>
		/// Out for delivery
		/// </summary>
		[EnumMember(Value = "EVENT_302")]
		EVENT_302,

		/// <summary>
		/// Delivery attempted
		/// </summary>
		[EnumMember(Value = "EVENT_304")]
		EVENT_304,

		/// <summary>
		/// Customer contacted to arrange delivery
		/// </summary>
		[EnumMember(Value = "EVENT_306")]
		EVENT_306,

		/// <summary>
		/// Delivery appointment scheduled
		/// </summary>
		[EnumMember(Value = "EVENT_307")]
		EVENT_307,

		/// <summary>
		/// Available for pickup
		/// </summary>
		[EnumMember(Value = "EVENT_308")]
		EVENT_308,

		/// <summary>
		/// Returned to seller
		/// </summary>
		[EnumMember(Value = "EVENT_309")]
		EVENT_309,

		/// <summary>
		/// Held by carrier - incorrect address
		/// </summary>
		[EnumMember(Value = "EVENT_401")]
		EVENT_401,

		/// <summary>
		/// Customs clearance delay
		/// </summary>
		[EnumMember(Value = "EVENT_402")]
		EVENT_402,

		/// <summary>
		/// Customer moved
		/// </summary>
		[EnumMember(Value = "EVENT_403")]
		EVENT_403,

		/// <summary>
		/// Delay in delivery due to external factors
		/// </summary>
		[EnumMember(Value = "EVENT_404")]
		EVENT_404,

		/// <summary>
		/// Shipment damaged
		/// </summary>
		[EnumMember(Value = "EVENT_405")]
		EVENT_405,

		/// <summary>
		/// Held by carrier
		/// </summary>
		[EnumMember(Value = "EVENT_406")]
		EVENT_406,

		/// <summary>
		/// Customer refused delivery
		/// </summary>
		[EnumMember(Value = "EVENT_407")]
		EVENT_407,

		/// <summary>
		/// Returning to seller
		/// </summary>
		[EnumMember(Value = "EVENT_408")]
		EVENT_408,

		/// <summary>
		/// Lost by carrier
		/// </summary>
		[EnumMember(Value = "EVENT_409")]
		EVENT_409,

		/// <summary>
		/// Paperwork received - did not receive shipment
		/// </summary>
		[EnumMember(Value = "EVENT_411")]
		EVENT_411,

		/// <summary>
		/// Shipment received - did not receive paperwork
		/// </summary>
		[EnumMember(Value = "EVENT_412")]
		EVENT_412,

		/// <summary>
		/// Held by carrier - customer refused shipment due to customs charges
		/// </summary>
		[EnumMember(Value = "EVENT_413")]
		EVENT_413,

		/// <summary>
		/// Missorted by carrier
		/// </summary>
		[EnumMember(Value = "EVENT_414")]
		EVENT_414,

		/// <summary>
		/// Received from prior carrier
		/// </summary>
		[EnumMember(Value = "EVENT_415")]
		EVENT_415,

		/// <summary>
		/// Undeliverable
		/// </summary>
		[EnumMember(Value = "EVENT_416")]
		EVENT_416,

		/// <summary>
		/// Shipment missorted
		/// </summary>
		[EnumMember(Value = "EVENT_417")]
		EVENT_417,

		/// <summary>
		/// Shipment delayed
		/// </summary>
		[EnumMember(Value = "EVENT_418")]
		EVENT_418,

		/// <summary>
		/// Address corrected - delivery rescheduled
		/// </summary>
		[EnumMember(Value = "EVENT_419")]
		EVENT_419,
	}
}
