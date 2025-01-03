namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using AmznSellingPartner.Clients.Attributes;

	using System.Collections.Generic;

	/// <summary>
	/// A list of serial numbers for the items associated with the `OrderItemId` value.
	/// </summary>
	[MaxItems(100)]
	public class OrderItemSerialNumbers : List<OrderItemSerialNumber>
	{
	}
}
