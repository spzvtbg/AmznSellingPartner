namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum Type
	{
		/// <summary>
		/// Indicates delivery preferred to front door
		/// </summary>
		[EnumMember(Value = "FRONT_DOOR")]
		FRONT_DOOR,

		/// <summary>
		/// Indicates delivery preferred to a delivery box
		/// </summary>
		[EnumMember(Value = "DELIVERY_BOX")]
		DELIVERY_BOX,

		/// <summary>
		/// Indicates delivery preferred to a gas meter box
		/// </summary>
		[EnumMember(Value = "GAS_METER_BOX")]
		GAS_METER_BOX,

		/// <summary>
		/// Indicates delivery preferred to a bicycle basket
		/// </summary>
		[EnumMember(Value = "BICYCLE_BASKET")]
		BICYCLE_BASKET,

		/// <summary>
		/// Indicates delivery preferred to a garage
		/// </summary>
		[EnumMember(Value = "GARAGE")]
		GARAGE,

		/// <summary>
		/// Indicates delivery preferred with a receptionist
		/// </summary>
		[EnumMember(Value = "RECEPTIONIST")]
		RECEPTIONIST,

		/// <summary>
		/// Indicates delivery preferred with a designated neighbor if the recipient is not available at the destination a
		/// dress
		/// </summary>
		[EnumMember(Value = "FALLBACK_NEIGHBOR_DELIVERY")]
		FALLBACK_NEIGHBOR_DELIVERY,

		/// <summary>
		/// Indicates delivery preferred as attended
		/// </summary>
		[EnumMember(Value = "DO_NOT_LEAVE_UNATTENDED")]
		DO_NOT_LEAVE_UNATTENDED,
	}
}
