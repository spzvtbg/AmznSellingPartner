namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum OrderType
	{
		/// <summary>
		/// An order that contains items for which the selling partner currently has inventory in stoc
		/// k.
		/// </summary>
		[EnumMember(Value = "StandardOrder")]
		StandardOrder,

		/// <summary>
		/// An order that contains items that have a long lead time to ship.
		/// </summary>
		[EnumMember(Value = "LongLeadTimeOrder")]
		LongLeadTimeOrder,

		/// <summary>
		/// An order that contains items with a release date that is in the future.
		/// </summary>
		[EnumMember(Value = "Preorder")]
		Preorder,

		/// <summary>
		/// An order that contains items that already have been released in the market but are currently
		/// out of stock and will be available in the future.
		/// </summary>
		[EnumMember(Value = "BackOrder")]
		BackOrder,

		/// <summary>
		/// A Sourcing On Demand order.
		/// </summary>
		[EnumMember(Value = "SourcingOnDemandOrder")]
		SourcingOnDemandOrder,
	}
}
