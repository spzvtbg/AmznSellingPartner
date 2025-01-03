namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum UnitOfMeasure
	{
		/// <summary>
		/// Unit of measure to represent individual piece.
		/// </summary>
		[EnumMember(Value = "Each")]
		Each,
	}
}
