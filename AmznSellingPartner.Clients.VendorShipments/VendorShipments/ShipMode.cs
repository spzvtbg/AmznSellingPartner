namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum ShipMode
	{
		/// <summary>
		/// Small parcel shipments are under 70 pounds per parcel and shipped with your own packaging or carrier supplied
		/// oxes.
		/// </summary>
		[EnumMember(Value = "SmallParcel")]
		SmallParcel,

		[EnumMember(Value = "LTL")]
		LTL,

		/// <summary>
		/// Truckload shipping is the movement of large amounts of homogeneous cargo, generally the amount necessary to fi
		/// l an entire semi-trailer or intermodal container.
		/// </summary>
		[EnumMember(Value = "TruckLoad")]
		TruckLoad,

		/// <summary>
		/// Shipping does not fill the entire truck.
		/// </summary>
		[EnumMember(Value = "LessThanTruckLoad")]
		LessThanTruckLoad,
	}
}
