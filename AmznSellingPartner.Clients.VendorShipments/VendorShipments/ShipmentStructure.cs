namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum ShipmentStructure
	{
		/// <summary>
		/// Shipment -> Order -> Pallet/Tare -> Carton/Package -> Item
		/// </summary>
		[EnumMember(Value = "PalletizedAssortmentCase")]
		PalletizedAssortmentCase,

		/// <summary>
		/// Shipment -> Order -> Carton/Package -> Item
		/// </summary>
		[EnumMember(Value = "LooseAssortmentCase")]
		LooseAssortmentCase,

		/// <summary>
		/// Shipment -> Order -> Pallet/Tare -> Item
		/// </summary>
		[EnumMember(Value = "PalletOfItems")]
		PalletOfItems,

		/// <summary>
		/// Shipment -> Order -> Pallet/Tare -> Item -> Carton/Package
		/// </summary>
		[EnumMember(Value = "PalletizedStandardCase")]
		PalletizedStandardCase,

		/// <summary>
		/// Shipment -> Order -> Item -> Carton/Package
		/// </summary>
		[EnumMember(Value = "LooseStandardCase")]
		LooseStandardCase,

		/// <summary>
		/// Shipment -> Pallet/Tare -> Order -> Item
		/// </summary>
		[EnumMember(Value = "MasterPallet")]
		MasterPallet,

		/// <summary>
		/// Shipment -> Carton/Package -> Order -> Item
		/// </summary>
		[EnumMember(Value = "MasterCase")]
		MasterCase,
	}
}
