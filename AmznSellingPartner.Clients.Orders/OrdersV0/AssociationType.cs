namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The type of association an item has with an order item
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AssociationType
	{
		/// <summary>
		/// The associated item is a service order
		/// </summary>
		[EnumMember(Value = "VALUE_ADD_SERVICE")]
		VALUE_ADD_SERVICE,
	}
}
