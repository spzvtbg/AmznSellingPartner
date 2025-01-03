namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum CodCollectionMethod
	{
		[EnumMember(Value = "DirectPayment")]
		DirectPayment,
	}
}
