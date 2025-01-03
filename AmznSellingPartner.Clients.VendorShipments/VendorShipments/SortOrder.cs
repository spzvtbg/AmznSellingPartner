namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum SortOrder
	{
		/// <summary>
		/// Sort the list by shipment label creation date in ascending order
		/// </summary>
		[EnumMember(Value = "ASC")]
		ASC,

		/// <summary>
		/// Sort the list by shipment label creation date in descending order
		/// </summary>
		[EnumMember(Value = "DESC")]
		DESC,
	}
}
