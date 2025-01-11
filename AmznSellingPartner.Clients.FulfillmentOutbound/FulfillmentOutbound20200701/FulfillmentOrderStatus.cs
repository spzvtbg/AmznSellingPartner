namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The current status of the fulfillment order.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum FulfillmentOrderStatus
	{
		/// <summary>
		/// The fulfillment order was received but not yet validated.
		/// </summary>
		[EnumMember(Value = "New")]
		New,

		/// <summary>
		/// The fulfillment order was received and validated. Validation includes determining that the
		/// destination address is valid and that Amazon's records indicate that the seller has enough
		/// sellable (undamaged) inventory to fulfill the order. The seller can cancel a fulfillment order
		/// that has a status of Received.
		/// </summary>
		[EnumMember(Value = "Received")]
		Received,

		/// <summary>
		/// The fulfillment order has been sent to Amazon's fulfillment network to begin shipment planning,
		/// but no unit in any shipment has been picked from inventory yet. The seller can cancel a fulfillment
		/// order that has a status of Planning.
		/// </summary>
		[EnumMember(Value = "Planning")]
		Planning,

		/// <summary>
		/// The process of picking units from inventory has begun on at least one shipment in the fulfillment
		/// order. The seller cannot cancel a fulfillment order that has a status of Processing.
		/// </summary>
		[EnumMember(Value = "Processing")]
		Processing,

		/// <summary>
		/// The fulfillment order has been cancelled by the seller.
		/// </summary>
		[EnumMember(Value = "Cancelled")]
		Cancelled,

		/// <summary>
		/// All item quantities in the fulfillment order have been fulfilled.
		/// </summary>
		[EnumMember(Value = "Complete")]
		Complete,

		/// <summary>
		/// Some item quantities in the fulfillment order were fulfilled; the rest were either cancelled
		/// or unfulfillable.
		/// </summary>
		[EnumMember(Value = "CompletePartialled")]
		CompletePartialled,

		/// <summary>
		/// No item quantities in the fulfillment order could be fulfilled because the Amazon fulfillment
		/// center workers found no inventory for those items or found no inventory that was in sellable
		/// (undamaged) condition.
		/// </summary>
		[EnumMember(Value = "Unfulfillable")]
		Unfulfillable,

		/// <summary>
		/// The fulfillment order was received but could not be validated. The reasons for this include
		/// an invalid destination address or Amazon's records indicating that the seller does not have
		/// enough sellable inventory to fulfill the order. When this happens, the fulfillment order is
		/// invalid and no items in the order will ship.
		/// </summary>
		[EnumMember(Value = "Invalid")]
		Invalid,
	}
}
