namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The status of the package being shipped.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Status
	{
		/// <summary>
		/// Package has been created but has not been picked up.
		/// </summary>
		[EnumMember(Value = "PreTransit")]
		PreTransit,

		/// <summary>
		/// Package has been picked up and is in transit.
		/// </summary>
		[EnumMember(Value = "InTransit")]
		InTransit,

		/// <summary>
		/// Package has has been delivered successfully.
		/// </summary>
		[EnumMember(Value = "Delivered")]
		Delivered,

		/// <summary>
		/// Package is lost.
		/// </summary>
		[EnumMember(Value = "Lost")]
		Lost,

		/// <summary>
		/// Package is out for delivery.
		/// </summary>
		[EnumMember(Value = "OutForDelivery")]
		OutForDelivery,

		/// <summary>
		/// Package has been rejected by the recipient.
		/// </summary>
		[EnumMember(Value = "Rejected")]
		Rejected,

		/// <summary>
		/// Package was undeliverable.
		/// </summary>
		[EnumMember(Value = "Undeliverable")]
		Undeliverable,

		/// <summary>
		/// Delivery was attempted to the recipient location, but was not delivered.
		/// </summary>
		[EnumMember(Value = "DeliveryAttempted")]
		DeliveryAttempted,

		/// <summary>
		/// Pickup was cancelled for the package.
		/// </summary>
		[EnumMember(Value = "PickupCancelled")]
		PickupCancelled,
	}
}
