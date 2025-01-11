namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The status of the Amazon Easy Ship order. This property is only included for Amazon Easy Ship
	/// orders.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EasyShipShipmentStatus
	{
		/// <summary>
		/// The package is awaiting the schedule for pick-up.
		/// </summary>
		[EnumMember(Value = "PendingSchedule")]
		PendingSchedule,

		/// <summary>
		/// Amazon has not yet picked up the package from the seller.
		/// </summary>
		[EnumMember(Value = "PendingPickUp")]
		PendingPickUp,

		/// <summary>
		/// The seller will deliver the package to the carrier.
		/// </summary>
		[EnumMember(Value = "PendingDropOff")]
		PendingDropOff,

		/// <summary>
		/// The seller canceled the pickup.
		/// </summary>
		[EnumMember(Value = "LabelCanceled")]
		LabelCanceled,

		/// <summary>
		/// Amazon has picked up the package from the seller.
		/// </summary>
		[EnumMember(Value = "PickedUp")]
		PickedUp,

		/// <summary>
		/// The package was delivered to the carrier by the seller.
		/// </summary>
		[EnumMember(Value = "DroppedOff")]
		DroppedOff,

		/// <summary>
		/// The package is at the origin fulfillment center.
		/// </summary>
		[EnumMember(Value = "AtOriginFC")]
		AtOriginFC,

		/// <summary>
		/// The package is at the destination fulfillment center.
		/// </summary>
		[EnumMember(Value = "AtDestinationFC")]
		AtDestinationFC,

		/// <summary>
		/// The package has been delivered.
		/// </summary>
		[EnumMember(Value = "Delivered")]
		Delivered,

		/// <summary>
		/// The package has been rejected by the buyer.
		/// </summary>
		[EnumMember(Value = "RejectedByBuyer")]
		RejectedByBuyer,

		/// <summary>
		/// The package cannot be delivered.
		/// </summary>
		[EnumMember(Value = "Undeliverable")]
		Undeliverable,

		/// <summary>
		/// The package was not delivered and is being returned to the seller.
		/// </summary>
		[EnumMember(Value = "ReturningToSeller")]
		ReturningToSeller,

		/// <summary>
		/// The package was not delivered and was returned to the seller.
		/// </summary>
		[EnumMember(Value = "ReturnedToSeller")]
		ReturnedToSeller,

		/// <summary>
		/// The package is lost.
		/// </summary>
		[EnumMember(Value = "Lost")]
		Lost,

		/// <summary>
		/// The package is out for delivery.
		/// </summary>
		[EnumMember(Value = "OutForDelivery")]
		OutForDelivery,

		/// <summary>
		/// The package was damaged by the carrier.
		/// </summary>
		[EnumMember(Value = "Damaged")]
		Damaged,
	}
}
