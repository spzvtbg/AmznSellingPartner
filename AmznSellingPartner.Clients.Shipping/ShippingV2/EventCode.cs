namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The tracking event type.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EventCode
	{
		/// <summary>
		/// Package has been created and is ready for pickup at the shippers location. This is a pre-transit status
		/// event code.
		/// </summary>
		[EnumMember(Value = "ReadyForReceive")]
		ReadyForReceive,

		/// <summary>
		/// Package has been picked up by the service provider.
		/// </summary>
		[EnumMember(Value = "PickupDone")]
		PickupDone,

		/// <summary>
		/// Package has been delivered.
		/// </summary>
		[EnumMember(Value = "Delivered")]
		Delivered,

		/// <summary>
		/// Package has departed from a particular location in carrier network.
		/// </summary>
		[EnumMember(Value = "Departed")]
		Departed,

		/// <summary>
		/// Delivery was attempted, but was unsuccessful.
		/// </summary>
		[EnumMember(Value = "DeliveryAttempted")]
		DeliveryAttempted,

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
		/// Package is in transit and has been received at a carrier location.
		/// </summary>
		[EnumMember(Value = "ArrivedAtCarrierFacility")]
		ArrivedAtCarrierFacility,

		/// <summary>
		/// Package was rejected by the recipient.
		/// </summary>
		[EnumMember(Value = "Rejected")]
		Rejected,

		/// <summary>
		/// Package is undeliverable.
		/// </summary>
		[EnumMember(Value = "Undeliverable")]
		Undeliverable,

		/// <summary>
		/// Pickup scheduled for the package was cancelled.
		/// </summary>
		[EnumMember(Value = "PickupCancelled")]
		PickupCancelled,
	}
}
