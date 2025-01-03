namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Additional location information
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AdditionalLocationInfo
	{
		/// <summary>
		/// As instructed
		/// </summary>
		[EnumMember(Value = "AS_INSTRUCTED")]
		AS_INSTRUCTED,

		/// <summary>
		/// Carport
		/// </summary>
		[EnumMember(Value = "CARPORT")]
		CARPORT,

		/// <summary>
		/// Picked up by customer
		/// </summary>
		[EnumMember(Value = "CUSTOMER_PICKUP")]
		CUSTOMER_PICKUP,

		/// <summary>
		/// Deck
		/// </summary>
		[EnumMember(Value = "DECK")]
		DECK,

		/// <summary>
		/// Resident
		/// </summary>
		[EnumMember(Value = "DOOR_PERSON")]
		DOOR_PERSON,

		/// <summary>
		/// Front desk
		/// </summary>
		[EnumMember(Value = "FRONT_DESK")]
		FRONT_DESK,

		/// <summary>
		/// Front door
		/// </summary>
		[EnumMember(Value = "FRONT_DOOR")]
		FRONT_DOOR,

		/// <summary>
		/// Garage
		/// </summary>
		[EnumMember(Value = "GARAGE")]
		GARAGE,

		/// <summary>
		/// Residential guard
		/// </summary>
		[EnumMember(Value = "GUARD")]
		GUARD,

		/// <summary>
		/// Mail room
		/// </summary>
		[EnumMember(Value = "MAIL_ROOM")]
		MAIL_ROOM,

		/// <summary>
		/// Mail slot
		/// </summary>
		[EnumMember(Value = "MAIL_SLOT")]
		MAIL_SLOT,

		/// <summary>
		/// Mailbox
		/// </summary>
		[EnumMember(Value = "MAILBOX")]
		MAILBOX,

		/// <summary>
		/// Delivered to male child
		/// </summary>
		[EnumMember(Value = "MC_BOY")]
		MC_BOY,

		/// <summary>
		/// Delivered to female child
		/// </summary>
		[EnumMember(Value = "MC_GIRL")]
		MC_GIRL,

		/// <summary>
		/// Delivered to male adult
		/// </summary>
		[EnumMember(Value = "MC_MAN")]
		MC_MAN,

		/// <summary>
		/// Delivered to female adult
		/// </summary>
		[EnumMember(Value = "MC_WOMAN")]
		MC_WOMAN,

		/// <summary>
		/// Delivered to neighbor
		/// </summary>
		[EnumMember(Value = "NEIGHBOR")]
		NEIGHBOR,

		/// <summary>
		/// Office
		/// </summary>
		[EnumMember(Value = "OFFICE")]
		OFFICE,

		/// <summary>
		/// Outbuilding
		/// </summary>
		[EnumMember(Value = "OUTBUILDING")]
		OUTBUILDING,

		/// <summary>
		/// Patio
		/// </summary>
		[EnumMember(Value = "PATIO")]
		PATIO,

		/// <summary>
		/// Porch
		/// </summary>
		[EnumMember(Value = "PORCH")]
		PORCH,

		/// <summary>
		/// Rear door
		/// </summary>
		[EnumMember(Value = "REAR_DOOR")]
		REAR_DOOR,

		/// <summary>
		/// Receptionist
		/// </summary>
		[EnumMember(Value = "RECEPTIONIST")]
		RECEPTIONIST,

		/// <summary>
		/// Resident
		/// </summary>
		[EnumMember(Value = "RECEIVER")]
		RECEIVER,

		/// <summary>
		/// Secure location
		/// </summary>
		[EnumMember(Value = "SECURE_LOCATION")]
		SECURE_LOCATION,

		/// <summary>
		/// Side door
		/// </summary>
		[EnumMember(Value = "SIDE_DOOR")]
		SIDE_DOOR,
	}
}
