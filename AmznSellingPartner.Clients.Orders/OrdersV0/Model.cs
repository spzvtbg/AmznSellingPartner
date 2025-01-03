namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum Model
	{
		/// <summary>
		/// Tax is withheld and remitted to the taxing authority by Amazon on behalf of the seller
		/// </summary>
		[EnumMember(Value = "MarketplaceFacilitator")]
		MarketplaceFacilitator,
	}
}
