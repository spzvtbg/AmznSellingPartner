namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum ShipmentFreightTerm
	{
		/// <summary>
		/// Buyer Pays / We Pay for the the transportation. Buyer pays for the shipment and provides Vendor and picks
		/// up shipment from vendor warehouse / location
		/// </summary>
		[EnumMember(Value = "Collect")]
		Collect,

		/// <summary>
		/// Vendor pays / They Pay for the transportation. Vendor pays for the shipment and ships the goods to buyer
		/// warehouse / location
		/// </summary>
		[EnumMember(Value = "Prepaid")]
		Prepaid,
	}
}
